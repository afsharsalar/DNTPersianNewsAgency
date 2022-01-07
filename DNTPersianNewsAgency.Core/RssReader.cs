using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders;

namespace DNTPersianNewsAgency.Core
{
    public static class RssReader
    {
        public static List<NewsModel> Read(NewsAgencyType? agency=null, NewsType? type=null)
        {
            var feeds = new NewsFeeds().ToList();

            if (agency.HasValue)
                feeds = feeds.Where(p => p.Agency == agency).ToList();

            if (type.HasValue)
                feeds = feeds.Where(p => p.Type == type.Value).ToList();

            var data = new List<NewsModel>();

            foreach (var feed in feeds)
            {
                if (feed.FeedUrl.StartsWith("https"))
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                }
                //var items = Task.Run(() => FeedReader.ReadAsync(feed.FeedUrl)).Result;
                var document = XDocument.Load(feed.FeedUrl);
                var items = from element in document.Element("rss").Elements("channel").Elements("item")
                    select new
                    {
                        Title = element.Element("title")?.Value,
                        Link = element.Element("link")?.Value,
                        Description = element.Element("description")?.Value
                    };
                          
                foreach (var item in items)
                {
                    try
                    {
                        string title = item.Title;
                        title = title.Replace("&quot;", @"""").Replace("&#187;", "«").Replace("&#171;", "»");

                        var summary = item.Description ?? "";
                        summary = summary.Replace("&quot;", @"""").Replace("&nbsp;", "").Replace("&zwnj;", " ").Replace("&zwnj;", " ").Replace(" &#187;", "«").Replace("&#171;", "»");
                        var link = item.Link;//item.Id == null ? item.Link : item.Id;
                        switch (feed.Agency)
                        {
                            case NewsAgencyType.Eghtesadonline:
                                summary = RemoveAllTags(summary);
                                link = item.Link;
                                break;
                            case NewsAgencyType.Radiosaham:
                                summary = RemoveAllTags(summary);
                                break;

                        }

                        if (summary.Length > 300)
                            summary = summary.Substring(0, 300) + "....";
                        data.Add(new NewsModel
                        {
                            Title = title,
                            Summary = summary,
                            Link = link,
                        });

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }


            }
            return data;
        }

        static string RemoveAllTags(string html)
        {
            return Regex.Replace(html, "<.*?>", String.Empty);

        }
    }
}

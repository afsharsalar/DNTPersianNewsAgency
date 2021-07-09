using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.MediaRSS;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class MediaRssParser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            MediaRssFeed feed = new MediaRssFeed(feedXml, channel);
            return feed;
        }
    }
}
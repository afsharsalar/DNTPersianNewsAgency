using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds._0._91;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class Rss091Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss091Feed feed = new Rss091Feed(feedXml, channel);
            return feed;
        }
    }
}

using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds._2._0;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class Rss20Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss20Feed feed = new Rss20Feed(feedXml, channel);
            return feed;
        }
    }
}
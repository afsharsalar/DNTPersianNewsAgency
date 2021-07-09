using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds._0._92;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class Rss092Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss092Feed feed = new Rss092Feed(feedXml, channel);
            return feed;
        }
    }
}

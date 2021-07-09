using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds._1._0;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class Rss10Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rdf = feedDoc.Root;
            var channel = rdf.GetElement("channel");
            Rss10Feed feed = new Rss10Feed(feedXml, channel);
            return feed;
        }
    }
}
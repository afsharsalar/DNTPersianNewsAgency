using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Atom;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal class AtomParser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            AtomFeed feed = new AtomFeed(feedXml, feedDoc.Root);
            return feed;
        }
    }
}

using System.Xml.Linq;
using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal abstract class AbstractXmlFeedParser : IFeedParser
    {
        public BaseFeed Parse(string feedXml)
        {
            XDocument feedDoc = XDocument.Parse(feedXml);

            return this.Parse(feedXml, feedDoc);
        }

        public abstract BaseFeed Parse(string feedXml, XDocument feedDoc);
    }
}

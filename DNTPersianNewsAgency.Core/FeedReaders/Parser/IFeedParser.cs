using DNTPersianNewsAgency.Core.FeedReaders.Feeds.Base;

namespace DNTPersianNewsAgency.Core.FeedReaders.Parser
{
    internal interface IFeedParser
    {
        BaseFeed Parse(string feedXml);
    }
}

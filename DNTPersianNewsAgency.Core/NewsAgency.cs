using System.Collections.Generic;

namespace DNTPersianNewsAgency.Core
{
    /// <summary>
    /// فیدر خبر گزاری ها
    /// </summary>
    public class NewsFeed
    {
        public NewsAgencyType Agency { get; set; }

        public NewsType Type { get; set; }

        public string FeedUrl { get; set; }


    }

    public class NewsFeeds : List<NewsFeed>
    {
        public NewsFeeds()
        {
            //isna

            this.Add(new NewsFeed
            {
                Type = NewsType.Other,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Scientific,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/5"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Culture,
                Agency=NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/20"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Political,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/14"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Economic,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/34"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Social,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/9"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.International,
                Agency = NewsAgencyType.Isna,
                FeedUrl = "https://www.isna.ir/rss/tp/17"
            });

            //Tasnim

            this.Add(new NewsFeed
            {
                Type = NewsType.Other,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/8/0/"
            });
            this.Add(new NewsFeed
            {
                Type = NewsType.Political,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/7/1"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.Sport,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/7/3"
            });

            this.Add(new NewsFeed
            {
                Type = NewsType.International,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/7/8/"
            });


            this.Add(new NewsFeed
            {
                Type = NewsType.Economic,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/7/7/"
            });


            this.Add(new NewsFeed
            {
                Type = NewsType.Culture,
                Agency = NewsAgencyType.Tasnim,
                FeedUrl = "https://www.tasnimnews.com/fa/rss/feed/0/7/4/"
            });

            



            //mehr
          
            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Other
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/2",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Culture
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/6",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Social
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/6",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Social
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/25",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Economic
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/653",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Economic
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/9",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Sport
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/7",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.Political
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mehrnews.com/rss/tp/8",
                Agency = NewsAgencyType.Mehr,
                Type = NewsType.International
            });

        }
    }
}

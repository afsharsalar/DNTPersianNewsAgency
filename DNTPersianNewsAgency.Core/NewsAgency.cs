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
                Type = NewsType.All,
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
                Type = NewsType.All,
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
                Type = NewsType.All
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


            //irna
            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.All
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/5",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.Political
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/20",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.Economic
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/32",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.Social
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/41",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.Culture
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/14",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.Sport
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.irna.ir/rss/tp/1",
                Agency = NewsAgencyType.Irna,
                Type = NewsType.International
            });

            //Ana

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/256",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Scientific
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/1",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Social
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/46",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Economic
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/106",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Political
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/124",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Culture
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/135",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.Sport
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ana.press/rss/tp/73",
                Agency = NewsAgencyType.Ana,
                Type = NewsType.International
            });



            //ilna

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.ilna.news/feeds/",
                Agency = NewsAgencyType.Ilna,
                Type = NewsType.All
            });


            //moj

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.mojnews.com/feeds/",
                Agency = NewsAgencyType.Moj,
                Type = NewsType.All
            });


            //Tabnak

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/1",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.Culture
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/2",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.Political
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/3",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.Social
            });

            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/4",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.Economic
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/5",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.International
            });


            this.Add(new NewsFeed
            {
                FeedUrl = "https://www.tabnak.ir/fa/rss/1/9",
                Agency = NewsAgencyType.Tabnak,
                Type = NewsType.Culture
            });
        }
    }
}

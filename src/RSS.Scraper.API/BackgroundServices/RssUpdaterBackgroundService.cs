using System.ServiceModel.Syndication;
using System.Xml;

namespace RSS.Scraper.API.BackgroundServices;

public class RssUpdaterBackgroundService : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using XmlReader reader = XmlReader.Create("https://visualstudiomagazine.com/rss-feeds/news.aspx");
        SyndicationFeed feed = SyndicationFeed.Load(reader);

        RssFeed rssFeed = new()
        {
            Description = feed.Description.Text,
            Link = feed.Links.Select(l=> l.Uri).FirstOrDefault().OriginalString,
            Title = feed.Title.Text,
        };
        foreach (SyndicationItem item in feed.Items)
        {

        }

        return Task.CompletedTask;
    }
}

public class RssFeed
{
    public int RssFeedId { get; set; }
    public string Link { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

using SimpleFeedReader;

namespace RSSReader.Leitor;

public class LeitorCrunchyroll : ILeitor
{
    public async Task<IEnumerable<FeedItem>> LerAsync(string uri)
    {
        FeedReader reader = new();
        IEnumerable<FeedItem> feed = await reader.RetrieveFeedAsync(uri);
           
        return feed;
    }
}

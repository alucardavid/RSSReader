using SimpleFeedReader;

namespace RSSReader.Leitor;
interface ILeitor
{
    Task<IEnumerable<FeedItem>> LerAsync(string uri);
}
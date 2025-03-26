
using Microsoft.EntityFrameworkCore;
using RSSReader.Leitor;
using RSSReader.Models;
using System.Linq;

LeitorCrunchyroll leitor = new();
var feed = await leitor.LerAsync("http://feeds.feedburner.com/crunchyroll/rss/anime");

var noDubItems = feed.Where(f => !f.Title.Contains("Dub")).ToList();

foreach (var item in noDubItems)
{
    Console.WriteLine($"Id: {item.Id}");    
    Console.WriteLine($"Title: {item.Title}");    
    Console.WriteLine($"Content: {item.Content}");    
    Console.WriteLine($"Categories: {string.Join(",", item.Categories!)}");    
    Console.WriteLine($"Uri: {item.Uri}");    
    Console.WriteLine($"LastUpdatedDate: {item.LastUpdatedDate}");    
    Console.WriteLine($"PublishDate: {item.PublishDate}");    
    Console.WriteLine($"Summary: {item.Summary}");    
    Console.WriteLine($"Images: {item.Images.Count()}");   
    Console.WriteLine(""); 

}

// using (var db = new Context())
// {
//     var rsses = await db.Rsses.ToListAsync();

//     rsses.ForEach(r => Console.WriteLine(r.Title));
// }
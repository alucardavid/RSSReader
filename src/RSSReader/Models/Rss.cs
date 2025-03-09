using System.ComponentModel.DataAnnotations.Schema;

namespace RSSReader.Models;

[Table("rss")]
public class Rss 
{
    [Column("id")]
    public int Id { get; set; }
    [Column("rss_id")]
    public int Rss_id { get; set; }
    [Column("title")]
    public string? Title { get; set; }
    [Column("created_at")]
    public DateTime Created_at { get; set; }
    [Column("updated_at")]
    public DateTime? Updated_at { get; set; }



}
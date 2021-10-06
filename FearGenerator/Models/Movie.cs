namespace FearGenerator.Models
{
  public class Movie
  {
    public int MovieId { get; set; }
    public string Title { get; set; }
    public string Rating { get; set; }
    public int Year { get; set; }
    public int Stars { get; set; }
    public int SubgenreId { get; set; }
    public virtual Subgenre Subgenre { get; set; }
  }
}
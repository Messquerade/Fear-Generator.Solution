using System.Collections.Generic;

namespace FearGenerator.Models
{
  public class Subgenre
  {
    public Subgenre()
    {
      this.Movies = new HashSet<Movie>();
    }

    public int SubgenreId {get; set;}
    public string Name {get; set;}
    public string Description { get; set;}
    public virtual ICollection<Movie> Movies { get; set;}
  }
}
using System.Collections.Generic;

namespace FearGenerator.Models
{
  public class Subgenre
  {
    public Subgenre()
    {
      this.Subgenre = new HashSet<Subgenre>();
    }

    public int SubgenreId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<Movie> Movies { get; set;}
  }
}
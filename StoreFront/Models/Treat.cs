using System.Collections.Generic;

namespace StoreFront.Models 
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public int Rating {get; set;}
    
    public ICollection<TreatFlavor> Flavors {get;}
  }
}
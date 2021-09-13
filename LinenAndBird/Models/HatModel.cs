using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LinenAndBird.Models
{
  public class HatModel
  {
    public string Designer { get; set; }
    public string Color { get; set; }
    public HatStyle Style { get; set; }



  }

  public enum HatStyle
  {
    Normal,
    OpenBack,
    WhiteBrim


  }

}

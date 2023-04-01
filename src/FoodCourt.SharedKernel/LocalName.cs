using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt.SharedKernel;
public class LocalName 
{
  public List<Local> Locals { get; set; } = new List<Local>();
}

public class Local
{

  public Language Lang { get; set; } = Language.Arabic;
  public string Value { get; set; } = string.Empty;
}

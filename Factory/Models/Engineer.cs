using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public List<MachineEngineer> JoinEntities { get; }
  }
}
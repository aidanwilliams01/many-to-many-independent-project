using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Name cannot be blank")]
    public string Name { get; set; }
    public List<MachineEngineer> JoinEntities { get; }
  }
}
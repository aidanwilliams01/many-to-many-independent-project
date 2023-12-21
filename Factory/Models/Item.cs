using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int ItemId { get; set; }

    public Item(string description)
    {
      Description = description;
    }
  
    public Item(string description, int id)
    {
      Description = description;
      ItemId = id;
    }
  }
}

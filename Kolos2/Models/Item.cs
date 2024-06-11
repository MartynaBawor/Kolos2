using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Models;
[Table("items")]
[PrimaryKey(nameof(Id))]
public class Item
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public int Weight { get; set; }
    
    public ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Models;
[Table("characters")]
[PrimaryKey(nameof(Id))]
public class Character
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(120)]
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    
    public ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();
    public ICollection<CharacterTitle> CharacterTitles { get; set; } = new List<CharacterTitle>();
}
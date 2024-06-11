using Kolos2.Models;

namespace Kolos2.DTOs;

public class CharacterDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<BackpackDTO> Items { get; set; } = null;
    public ICollection<TitlesDTO> Titles { get; set; } = null;
}
public class BackpackDTO
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Amount { get; set; }
}
public class TitlesDTO
{
    public string title { get; set; }
    public DateTime AquiredAt { get; set; }
}

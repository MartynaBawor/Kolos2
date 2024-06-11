using Kolos2.Data;
using Kolos2.DTOs;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Services;

public class DbServices : IDbServices
{
    private readonly DatabaseContext _context;
    public DbServices(DatabaseContext context)
    {
        _context = context;
    }


    public async Task<CharacterDTO> GetCharacter(int characterId)
    {
        var character = await _context.Characters
            .Include(c => c.CharacterTitles)
            .ThenInclude(ct => ct.Title)
            .Include(c => c.Backpacks)
            .ThenInclude(b => b.Item)
            .FirstOrDefaultAsync(c => c.Id == characterId);
        var backpackItems = character.Backpacks.Select(b => new BackpackDTO
        {
            Name = b.Item.Name,
            Weight = b.Item.Weight,
            Amount = b.Amount
        }).ToList();
        var titles = character.CharacterTitles.Select(ct => new TitlesDTO
        {
            title = ct.Title.Name,
            AquiredAt = ct.AcquiredAt
        }).ToList();
        return new CharacterDTO()
        {
            FirstName = character.FirstName,
            LastName = character.LastName,
            CurrentWeight = character.CurrentWeight,
            MaxWeight = character.MaxWeight,
            Items = backpackItems,
            Titles = titles
        };
    }
}
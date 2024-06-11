using Kolos2.DTOs;
using Kolos2.Models;

namespace Kolos2.Services;

public interface IDbServices
{
  Task<CharacterDTO> GetCharacter(int characterId);
}
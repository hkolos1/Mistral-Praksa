using Mistral_Internship.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mistral_Internship.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}

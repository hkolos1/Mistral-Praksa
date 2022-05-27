using Mistral_Internship.Dtos.Character;
using Mistral_Internship.Dtos.Weapon;
using Mistral_Internship.Models;
using System.Threading.Tasks;

namespace Mistral_Internship.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}

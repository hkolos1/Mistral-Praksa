using Mistral_Internship.Dtos.Fight;
using Mistral_Internship.Models;
using System.Threading.Tasks;

namespace Mistral_Internship.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);

    }
}

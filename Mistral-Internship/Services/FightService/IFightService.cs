using Mistral_Internship.Dtos.Fight;
using Mistral_Internship.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mistral_Internship.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);

        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();

    }
}

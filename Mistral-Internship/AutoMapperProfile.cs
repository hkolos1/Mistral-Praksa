using AutoMapper;
using Mistral_Internship.Dtos.Character;
using Mistral_Internship.Dtos.Fight;
using Mistral_Internship.Dtos.Skill;
using Mistral_Internship.Dtos.Weapon;
using Mistral_Internship.Models;

namespace Mistral_Internship
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();

        }

    }
}

using AutoMapper;
using Mistral_Internship.Dtos.Character;
using Mistral_Internship.Models;

namespace Mistral_Internship
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();

        }

    }
}

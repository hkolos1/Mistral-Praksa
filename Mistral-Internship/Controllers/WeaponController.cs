using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mistral_Internship.Dtos.Character;
using Mistral_Internship.Dtos.Weapon;
using Mistral_Internship.Models;
using Mistral_Internship.Services.WeaponService;
using System.Threading.Tasks;

namespace Mistral_Internship.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}

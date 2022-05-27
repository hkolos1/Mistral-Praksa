using Microsoft.AspNetCore.Mvc;
using Mistral_Internship.Services.FightService;

namespace Mistral_Internship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Mistral_Internship.Models;

namespace Mistral_Internship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knight);
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mistral_Internship.Data;
using Mistral_Internship.Models;

namespace Mistral_Internship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private DataContext _expressoDbContext;

        public ReservationsController(DataContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _expressoDbContext.Reservations.Add(reservation);
            _expressoDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}

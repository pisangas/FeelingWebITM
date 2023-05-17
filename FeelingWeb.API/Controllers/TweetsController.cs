using FeelingWeb.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FeelingWeb.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TweetsController : ControllerBase
    {
        private readonly DataContext _context;

        public TweetsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            return Ok(await _context.Tweets.ToListAsync());
        }
    }
}

using CinemaProject.Data;
using CinemaProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CinemaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Genres1Controller : ControllerBase
    {
        private readonly DatabaseContext _context;

        public Genres1Controller(DatabaseContext context)
        {
            _context = context;
        }
        // GET: api/<Genres1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Genres1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Genres1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpGet("eksempel")]
        public async Task<ActionResult<Genre>> eks()
        {
            return await _context.Genre.Where((Genre g) => g.GenreName == "Action").FirstOrDefaultAsync();
        }

        public async Task<ActionResult<List<Movie>>> eksempel1()
        {
            var tt = await _context.Movie.Include((x) => x.actors).Where(movie => movie.Id == 1).ToListAsync();
            return tt;
        }
        //[HttpGet("EnTilMange")]
        //public async Task<ActionResult<List<Actor>>> actorsMovie()
        //{
        //    var tt = await _context.Genre.Include((x) => x.genres).ToListAsync();
        //    return tt;
        //}
    }
}

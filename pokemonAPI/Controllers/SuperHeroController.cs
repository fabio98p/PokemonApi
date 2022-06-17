using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        public DataContext _context { get; }

        public SuperHeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroById(int id)
        {
            SuperHero hero = await _context.SuperHeroes.FirstOrDefaultAsync(hero => hero.Id == id);
            if (hero == null)
            {
                return BadRequest("hero not found");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateAddHero(SuperHero request)
        {
            SuperHero dbHero = await _context.SuperHeroes.FirstOrDefaultAsync(hero => hero.Id == request.Id);
            if (dbHero == null)
            {
                return BadRequest("hero not found");
            }

            dbHero.Name = (request.Name != "") ? request.Name : dbHero.Name;
            dbHero.FirstName = (request.FirstName != "") ? request.FirstName : dbHero.FirstName;
            dbHero.LastName = (request.LastName != "") ? request.LastName : dbHero.LastName;
            dbHero.Place = (request.Place != "") ? request.Place : dbHero.Place;

            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHeroById(int id)
        {
            SuperHero dbHero = await _context.SuperHeroes.FirstOrDefaultAsync(hero => hero.Id == id);
            if (dbHero == null)
            {
                return BadRequest("hero not found");
            }
            _context.SuperHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}

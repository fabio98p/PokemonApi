//using Microsoft.AspNetCore.Mvc;

//namespace pokemonAPI.Controllers
//{
//    public class GenericCrudController<T> : ControllerBase where T : class
//    {
//        private readonly DataContext context;
//        private DbSet<T> entities;

//        public GenericCrudController(DataContext context)
//        {
//            this.context = context;
//            this.entities = context.Set<T>();
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<T>>> Get()
//        {
//            return Ok(await context.Set<T>().ToListAsync());
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<T>> GetHeroById(int id)
//        {
//            var entity = await entities.FindAsync(id);
//            if (entity == null)
//            {
//                return NotFound();
//            }
//            return Ok(entity);
//        }

//        [HttpPost]
//        public async Task<ActionResult<List<T>>> AddHero(T entity)
//        {
//            entities.AddAsync(entity);
//            await context.SaveChangesAsync();
//            return Ok(await context.SuperHeroes.ToListAsync());
//        }

//        [HttpPut]
//        public async Task<ActionResult<List<T>>> UpdateAddHero(Guid id, T request)
//        {
//            T dbHero = await context.Set<T>().FindAsync(id);

//            if (!await context.Set<T>().AnyAsync(e => e.Id == id))
//            {
//                return BadRequest("hero not found");
//            }

//            dbHero.Name = (request.Name != "") ? request.Name : dbHero.Name;
//            dbHero.FirstName = (request.FirstName != "") ? request.FirstName : dbHero.FirstName;
//            dbHero.LastName = (request.LastName != "") ? request.LastName : dbHero.LastName;
//            dbHero.Place = (request.Place != "") ? request.Place : dbHero.Place;

//            await context.SaveChangesAsync();
//            return Ok(await context.SuperHeroes.ToListAsync());
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult<List<T>>> DeleteHeroById(int id)
//        {
//            T dbHero = await context.SuperHeroes.FirstOrDefaultAsync(hero => hero.Id == id);
//            if (dbHero == null)
//            {
//                return BadRequest("hero not found");
//            }
//            context.SuperHeroes.Remove(dbHero);
//            await context.SaveChangesAsync();

//            return Ok(await context.SuperHeroes.ToListAsync());
//        }
//    }
//}

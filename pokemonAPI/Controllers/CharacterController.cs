using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pokemonAPI.CreateDto;
using System.Linq;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext context;

        public CharacterController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacterByUserId(int userId)
        {
            var characters = await context.Characters
                .Where(c => c.UserId == userId)
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .ToListAsync();
            if(!characters.Any()) return NotFound($"characters not found assegned '{userId}' userId");
            return characters;
        }

        [HttpPost]
        public async Task<ActionResult<Character>> AddCharacter(CreateCharacterDTO request)
        {
            var user = await context.Users.FindAsync(request.UserId);
            if (user == null)
                return NotFound();

            var newCharacter = new Character
            {
                Name = request.Name,
                RpgClass = request.RpgClass,
                User = user
            };

            context.Characters.Add(newCharacter);
            await context.SaveChangesAsync();
            return newCharacter;
        }
    }
}

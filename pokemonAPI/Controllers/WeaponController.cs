using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pokemonAPI.CreateDto;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private readonly DataContext context;

        public WeaponController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Weapon>>> Get()
        {
            return await context.Weapons.ToListAsync();
        }

        [HttpGet("{characterId}")]
        public async Task<ActionResult<List<Weapon>>> GetWeaponByUserId(int characterId)
        {
            var weapon = await context.Weapons
               .Where(c => c.CharacterId == characterId)
               .ToListAsync();
            if (!weapon.Any()) return NotFound($"weapon not found assegned '{characterId}' CharacterId");
            return weapon;
        }

        [HttpPost]
        public async Task<ActionResult<Character>> AddWeapon(CreateWeaponDTO weapon)
        {
            var character = await context.Characters.FindAsync(weapon.CharacterId);
            if (character == null)
                return NotFound();

            var newWeapon = new Weapon
            {
                Name = weapon.Name,
                Damage = weapon.Damage,
                Character = character,
            };

            context.Weapons.Add(newWeapon);
            await context.SaveChangesAsync();
            return character;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pokemonAPI.CreateDto;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        private readonly DataContext context;

        public SkillController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet("{characterId}")]
        public async Task<ActionResult<List<Skill>>> GetSkillsByCharacterId(int characterId)
        {
            var character = await context.Characters
                .Where(c => c.Id == characterId)
                .Include(c => c.Skills)
                .FirstOrDefaultAsync();
            if (character == null)
                return NotFound();
            List<Skill> skill = character.Skills.ToList();
            if (skill == null)
                return NotFound();

            return skill;
        }

        [HttpPost]
        public async Task<ActionResult<Character>> AddCharacter(SkillDTO request)
        {
            var character = await context.Characters
                .Where(c => c.Id == request.CharacterId)
                .Include(c => c.Skills)
                .FirstOrDefaultAsync();
            if (character == null)
                return NotFound();

            var skill = await context.Skills.FindAsync(request.SkillId);
            if (skill == null)
                return NotFound();

            character.Skills.Add(skill);
            await context.SaveChangesAsync();

            return character;
        }
    }
}

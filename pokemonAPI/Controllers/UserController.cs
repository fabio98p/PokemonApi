using Microsoft.AspNetCore.Mvc;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DataContext context;

        public UserController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<ActionResult<Character>> AddCharacter(CreateCharacterDTO request)
        //{
        //    var user = await context.Users.FindAsync(request.UserId);
        //    if (user == null)
        //        return NotFound();

        //    var newCharacter = new Character
        //    {
        //        Name = request.Name,
        //        RpgClass = request.RpgClass,
        //        User = user
        //    };

        //    context.Characters.Add(newCharacter);
        //    await context.SaveChangesAsync();
        //    return newCharacter;
        //}
    }
}

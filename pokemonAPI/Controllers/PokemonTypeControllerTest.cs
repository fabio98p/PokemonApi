using Microsoft.AspNetCore.Mvc;
using pokemonAPI.IService;
using pokemonAPI.Models;

namespace pokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonTypeControllerTest : ControllerBase
    {
		private IPokemonTypeService service;
		protected readonly DataContext ctx;
		private DbSet<PokemonType> entities;
		//private IMapper mapper;
		public PokemonTypeControllerTest(IPokemonTypeService service/*, IMapper mapper*/)
		{
			this.service = service;
			//this.mapper = mapper;

		}
		[HttpGet]
		public IActionResult GetAllPokemonType()
		{

			Console.WriteLine("sto facendo GetAll");
			var pokemonTypes = service.GetAll();
			//var courseDTOs = mapper.Map<IEnumerable<CourseDTO>>(course);
			return Ok(pokemonTypes);
		}
		[HttpGet]
		[Route("{id}")]
		public IActionResult GetById(Guid id)
		{
			var pokemonType = service.GetById(id);
			//var courseDTO = mapper.Map<CourseDTO>(course);
			return Ok(pokemonType);
		}
		[HttpPost]
		public IActionResult CreateCourse(PokemonType pokemonType)
		{
			//var course = mapper.Map<Course>(courseDTO);
			var resultPokemonType = service.Create(pokemonType);
			//var resDTO = mapper.Map<CourseDTO>(course);
			return Ok(resultPokemonType);
		}
		[HttpPut]
		public IActionResult UpdateCourse(PokemonType pokemonType)
		{
			//var course = mapper.Map<Course>(courseDTO);
			var resultPokemonType = service.Update(pokemonType);
			//var resDTO = mapper.Map<CourseDTO>(course);
			return Ok(resultPokemonType);
		}
		[HttpDelete]
		public IActionResult RemoveCourse(PokemonType pokemonType)
		{
			//var course = mapper.Map<Course>(courseDTO);
			service.Delete(pokemonType);
			//var resDTO = mapper.Map<CourseDTO>(course);
			return Ok(pokemonType);
		}

		[HttpDelete]
		[Route("{id}")]
		public IActionResult RemoveCourse(Guid id)
		{
			//var course = service.GetCourseById(id);
			service.Delete(id);
			//var resDTO = mapper.Map<CourseDTO>(course);
			return Ok(id);
		}
	}
}

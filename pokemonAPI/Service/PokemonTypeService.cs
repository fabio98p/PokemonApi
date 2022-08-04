using pokemonAPI.IService;
using pokemonAPI.Models;

namespace pokemonAPI.Service
{
    public class PokemonTypeService : GenericCrudService<PokemonType, Guid>, IPokemonTypeService
    {
        public PokemonTypeService(DataContext ctx): base(ctx)
        {

        }
    }
}

using pokemonAPI.IService;
namespace pokemonAPI.Service
{
    public class GenericCrudService<T, K> : IGenericCrudService<T, K> where T : class
	{
		protected readonly DataContext ctx;
		private DbSet<T> entities;
		public GenericCrudService(DataContext ctx)
		{
			this.ctx = ctx;
			this.entities = ctx.Set<T>();
		}
		public virtual IEnumerable<T> GetAll()
		{
			Console.WriteLine("sto facendo GetAll");
			return entities.AsEnumerable();
		}

		public virtual T GetById(K id)
		{
			return entities.Find(id);
		}

		public virtual T Create(T newElement)
		{
			entities.Add(newElement);
			//ctx.SaveChanges();  Non salviamo qui, ma in DidacticsService
			return newElement;
		}
		public T Update(T newElement)
		{
			entities.Update(newElement);
			return newElement;
			//int numChanges = ctx.SaveChanges();
			//return numChanges > 0;
		}

		public void Delete(K id)
		{
			T found = entities.Find(id);
			//if (found == null)
			//{
			//    return false;
			//}
			entities.Remove(found);
			//ctx.SaveChanges();
			//return true;
		}
		public void Delete(T element)
		{
			entities.Remove(element);

			//int changes = ctx.SaveChanges();
			//if (changes == 0)
			//{
			//    return false;
			//}
			//return true;

		}

	}
}

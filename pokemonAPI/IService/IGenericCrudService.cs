namespace pokemonAPI.IService
{
    public interface IGenericCrudService<T, K>
    {
		T Create(T newElement);
		void Delete(T element);
		void Delete(K key);
		T Update(T newElement);
		T GetById(K key);
		IEnumerable<T> GetAll();
	}
}

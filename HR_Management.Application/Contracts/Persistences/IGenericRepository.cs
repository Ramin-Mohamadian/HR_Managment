namespace HR_Management.Application.Contracts.Persistences
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

    }
}

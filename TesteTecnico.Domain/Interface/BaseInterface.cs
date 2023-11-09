namespace TesteTecnico.Domain.Interface
{
    public interface BaseInterface<T> where T : class
    {
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}

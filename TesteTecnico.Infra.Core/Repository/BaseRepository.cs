using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Repository;
using TesteTecnico.Infra.Core.Context;

namespace TesteTecnico.Infra.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntitie
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Remove(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public async Task<int> Insert(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Add(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public async Task<int> Update(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Update(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}

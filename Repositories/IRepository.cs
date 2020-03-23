using EmailService.Context;
using EmailService.Services.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.Repositories
{
    public interface IRepository<TEntity, Key>
        where TEntity : class, IDataEntity
    {
        IQueryable<TEntity> Select();
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Key id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity, Key key);
        Task DeleteAsync(Key id);
        Task<PageDto<TEntity>> PagedIndex(int pageIndex, int itemsPerPage);
        Task SaveAsync();
    }
}

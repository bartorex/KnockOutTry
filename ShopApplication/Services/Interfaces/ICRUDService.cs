using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopApplication.Services.Interfaces
{
    public interface ICRUDService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> GetById(TEntity tEntity);
        Task Update(TEntity tEntity);
        Task Delete(TEntity tEntity);
        Task Add(TEntity tEntity);
    }
}

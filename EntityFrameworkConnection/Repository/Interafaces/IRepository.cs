using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkConnection.Repository.Interafaces
{
    public interface IRepository<TEntity>
    {
        Task<IQueryable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity tEntity);
        Task Update(TEntity tEntity);
        Task Delete(TEntity tEntity);
    }
}

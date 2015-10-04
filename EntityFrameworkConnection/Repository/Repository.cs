using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using EntityFrameworkConnection.Context;
using EntityFrameworkConnection.Repository.Interafaces;

namespace EntityFrameworkConnection.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        private readonly ShopContext shopContext;

        public Repository(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return shopContext.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id)
        {
            return shopContext.Set<TEntity>().Find(id);
        }

        public async Task Add(TEntity tEntity)
        {
            shopContext.Set<TEntity>().Add(tEntity);
            await shopContext.SaveChangesAsync();
        }

        public async Task Update(TEntity tEntity)
        {
            TEntity toModify = shopContext.Set<TEntity>().Find(tEntity.Id);
            toModify = tEntity;
            
            shopContext.Entry(toModify).State = EntityState.Modified;
            await shopContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity tEntity)
        {
            shopContext.Set<TEntity>().Remove(tEntity);
            await shopContext.SaveChangesAsync();
        }
    }
}

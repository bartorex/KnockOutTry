using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using EntityFrameworkConnection.Repository.Interafaces;
using ShopApplication.Services.Interfaces;

namespace ShopApplication.Services
{
    public class CRUDService<TEntity> : ICRUDService<TEntity> where TEntity: class ,IEntity
    {
        private readonly IRepository<TEntity> repository;

        public CRUDService(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
           return await repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<TEntity> GetById(TEntity tEntity)
        {
            return await repository.GetById(tEntity.Id);
        }

        public async Task Update(TEntity tEntity)
        {
            await repository.Update(tEntity);
        }

        public async Task Delete(TEntity tEntity)
        {
            await repository.Delete(tEntity);
        }

        public async Task Add(TEntity tEntity)
        {
            await repository.Add(tEntity);
        }
    }
}

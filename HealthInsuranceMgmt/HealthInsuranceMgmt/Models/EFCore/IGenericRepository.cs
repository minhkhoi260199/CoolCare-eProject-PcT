using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.EFCore
{
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllWithoutTracking();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(int id);

        Task<TEntity> GetByIdHavingTracking(int id);
    }
}
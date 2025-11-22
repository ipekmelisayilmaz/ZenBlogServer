using System.Linq.Expressions;
using ZenBlog.Domain.Entities.Common;

namespace ZenBlog.Application.Contracts.Persistence;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAllAsync();
    IQueryable<TEntity> GetQuery();//lazy loading ertelenmiş sorgu filtreleyerek getir sonra işlem yap
    Task<TEntity> GetByIdAsync(Guid id);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter);//tek bir kaydı özel bir şarta göre veritabanından çekmek için kullanılır.
    Task CreateAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);





}



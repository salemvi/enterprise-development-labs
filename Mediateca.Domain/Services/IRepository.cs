namespace Mediateca.Domain.Services;

public interface IRepository<TEntity, TKey>
    where TEntity : class
    where TKey : struct
{

    Task<IList<TEntity>> GetAll();

    Task<TEntity?> Get(TKey key);

    Task<TEntity> Add(TEntity entity);

    Task<TEntity> Update(TEntity entity);

    Task<bool> Delete(TKey key);
}

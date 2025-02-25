namespace BlogIdentityApi.Base.Methods;

public interface IGetByIdAsync<TEntity>
{
    public Task<TEntity> GetByIdAsync(Guid id);
}

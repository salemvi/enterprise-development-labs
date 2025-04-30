namespace Mediateca.Application.Contracts;
public interface ICrudService<TDto, TCreateUpdateDto, TKey>
    where TDto : class
    where TCreateUpdateDto : class
    where TKey : struct
{
    public Task<TDto> Create(TCreateUpdateDto newDto);

    public Task<TDto> Update(TKey key, TCreateUpdateDto newDto);

    public Task<bool> Delete(TKey id);

    public Task<IList<TDto>> GetList();

    public Task<TDto?> GetById(TKey id);
}

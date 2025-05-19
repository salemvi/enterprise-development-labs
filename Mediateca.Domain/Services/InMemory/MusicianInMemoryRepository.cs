using Mediateca.Domain.Model;
using Mediateca.Domain.Data;

namespace Mediateca.Domain.Services.InMemory;

public class MusicianInMemoryRepository : IRepository<Musician, int>
{
    private List<Musician> _musicians;

    public MusicianInMemoryRepository()
    {
        _musicians = DataSeeder.Musicians;
    }

    public Task<Musician> Add(Musician entity)
    {
        try
        {
            _musicians.Add(entity);
        }
        catch
        {
            return null!;
        }
        return Task.FromResult(entity);
    }

    public async Task<bool> Delete(int key)
    {
        try
        {
            var musician = await Get(key);
            if (musician != null)
                _musicians.Remove(musician);
        }
        catch
        {
            return false;
        }
        return true;
    }

    public async Task<Musician> Update(Musician entity)
    {
        try
        {
            await Delete(entity.Id);
            await Add(entity);
        }
        catch
        {
            return null!;
        }
        return entity;
    }

    public Task<Musician?> Get(int key) =>
        Task.FromResult(_musicians.FirstOrDefault(item => item.Id == key));

    public Task<IList<Musician>> GetAll() =>
        Task.FromResult((IList<Musician>)_musicians);
}

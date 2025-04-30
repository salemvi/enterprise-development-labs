using Mediateca.Domain.Data;
using Mediateca.Domain.Model;
using System.Xml.Linq;

namespace Mediateca.Domain.Services.InMemory;

public class AlbumInMemoryRepository : IRepository<Album, int>
{
    private List<Album> _albums;

    public AlbumInMemoryRepository()
    {
        _albums = DataSeeder.Albums;
    }

    public Task<Album> Add(Album entity)
    {
        try
        {
            _albums.Add(entity);
        }
        catch
        {
            return null!;
        }
        return Task.FromResult(entity);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(int key)
    {
        try
        {
            var album = await Get(key);
            if (album != null)
                _albums.Remove(album);
        }
        catch
        {
            return false;
        }
        return true;
    }

    public Task<Album?> Get(int key) =>
        Task.FromResult(_albums.FirstOrDefault(item => item.Id == key));

    public Task<IList<Album>> GetAll() =>
        Task.FromResult((IList<Album>)_albums);

    /// <inheritdoc/>
    public async Task<Album> Update(Album entity)
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
}

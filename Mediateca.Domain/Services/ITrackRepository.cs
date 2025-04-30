using Mediateca.Domain.Model;

namespace Mediateca.Domain.Services;

public interface ITrackRepository : IRepository<Track, int>
{

    Task<IList<string>> GetMusiciansInfo();

    Task<IList<string>> GetAlbumInfo(int key);

    Task<IList<string>> GetAlbumsByYear(int key);

    Task<IList<string>> GetTop5AlbumsByDuration();

    Task<IList<string>> GetMaxAlbumsArtist();

    Task<IList<string>> GetAlbumsMetrics();
}

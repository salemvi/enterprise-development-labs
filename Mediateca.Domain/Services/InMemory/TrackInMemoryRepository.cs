
public class TrackInMemoryRepository : ITrackRepository
{


    private List<Track> _tracks;

    public TrackInMemoryRepository()
    {


        _tracks = DataSeeder.Tracks;
    }
}
namespace Mediateca.Application.Contracts.Track;

public record TrackDto(int Id, string? Name, int? TrackNumber, string? Time, int AlbumId);

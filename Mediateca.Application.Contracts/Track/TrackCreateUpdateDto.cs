namespace Mediateca.Application.Contracts.Track;
public record TrackCreateUpdateDto(string? Name, int? TrackNumber, string? Time, int AlbumId);
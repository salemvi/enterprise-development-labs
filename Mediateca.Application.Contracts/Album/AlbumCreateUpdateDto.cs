namespace Mediateca.Application.Contracts.Album;

public record AlbumCreateUpdateDto(string? Name, int? Year, int MusicianId);

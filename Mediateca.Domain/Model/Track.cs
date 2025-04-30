using System.ComponentModel.DataAnnotations;

namespace Mediateca.Domain.Model;

public class Track
{
    [Key]
    public required int Id { get; set; }

    public string? Name { get; set; }

    public int? TrackNumber { get; set; }

    public string? Time { get; set; }

    public required int AlbumId { get; set; }

    public virtual Album? Album { get; set; }
}

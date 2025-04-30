using System.ComponentModel.DataAnnotations;

namespace Mediateca.Domain.Model;

public class Album
{
    [Key]
    public required int Id { get; set; }

    public string? Name { get; set; }

    public int? Year { get; set; }

    public required int MusicianId { get; set; }

    public virtual Musician? Musician { get; set; }

    public virtual List<Track>? Tracks { get; set; }
}

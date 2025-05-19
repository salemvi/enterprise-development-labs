using Mediateca.Domain.Model;
using System.ComponentModel.DataAnnotations;

namespace Mediateca.Domain.Model;

public class Musician
{
    [Key]
    public required int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual List<Album>? Albums { get; set; }
}

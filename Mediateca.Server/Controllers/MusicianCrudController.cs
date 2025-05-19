using Mediateca.Application.Contracts;
using Mediateca.Application.Contracts.Musician;

namespace Mediateca.Server.Controllers;

public class MusicianController(ICrudService<MusicianDto, MusicianCreateUpdateDto, int> crudService)
    : CrudControllerBase<MusicianDto, MusicianCreateUpdateDto, int>(crudService);

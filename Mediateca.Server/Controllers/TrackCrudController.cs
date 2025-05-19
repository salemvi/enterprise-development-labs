using Mediateca.Application.Contracts;
using Mediateca.Application.Contracts.Track;

namespace Mediateca.Server.Controllers;

public class TrackController(ICrudService<TrackDto, TrackCreateUpdateDto, int> crudService)
    : CrudControllerBase<TrackDto, TrackCreateUpdateDto, int>(crudService);

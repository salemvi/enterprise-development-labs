using Mediateca.Application.Contracts;
using Mediateca.Application.Contracts.Album;

namespace Mediateca.Server.Controllers;

public class AlbumController(ICrudService<AlbumDto, AlbumCreateUpdateDto, int> crudService)
    : CrudControllerBase<AlbumDto, AlbumCreateUpdateDto, int>(crudService);

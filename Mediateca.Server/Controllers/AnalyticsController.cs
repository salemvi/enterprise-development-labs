using Mediateca.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Mediateca.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnalyticsController(IAnalyticsService service): ControllerBase
{

    [HttpGet("GetMusiciansInfo")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetMusiciansInfo() =>
        Ok(await service.GetMusiciansInfo());

    [HttpGet("GetAlbumInfo/{id}")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetAlbumInfo(int id) =>
        Ok(await service.GetAlbumInfo(id));

    [HttpGet("GetAlbumsByYear/{year}")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetAlbumsByYear(int year) =>
        Ok(await service.GetAlbumsByYear(year));

    [HttpGet("GetTop5AlbumsByDuration")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetTop5AlbumsByDuration() =>
        Ok(await service.GetTop5AlbumsByDuration());

    [HttpGet("GetMaxAlbumsArtist")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetMaxAlbumsArtist() =>
        Ok(await service.GetMaxAlbumsArtist());

    [HttpGet("GetAlbumsMetrics")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<string>>> GetAlbumsMetrics() =>
        Ok(await service.GetAlbumsMetrics());
}

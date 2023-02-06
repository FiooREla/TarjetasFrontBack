using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarjetaPresentacion.API.Helpers;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Services;

namespace TarjetaPresentacion.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrabajadorController : Controller {

    private readonly ITrabajadorService _trabajadorService;
    private readonly StatusCodeBuilder _statusCodeBuilder;

    public TrabajadorController(ITrabajadorService trabajadorService , StatusCodeBuilder statusCodeBuilder)    {
       
        _trabajadorService = trabajadorService;
        _statusCodeBuilder = statusCodeBuilder;

    }
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        
        EstadoDeEjecucion<IEnumerable<Trabajador>> estadoDeEjecucion = await _trabajadorService.GetAllAsync();
        return _statusCodeBuilder.ConstruirAPartirDeEstado(estadoDeEjecucion);

    }
    [HttpGet("FindByID")]
    public async Task<IActionResult> FindByID([FromQuery(Name ="id")] string id)
    {

        EstadoDeEjecucion<Trabajador> estadoDeEjecucion = await _trabajadorService.FindByIDAsync(id);
        return _statusCodeBuilder.ConstruirAPartirDeEstado(estadoDeEjecucion);

    }
}

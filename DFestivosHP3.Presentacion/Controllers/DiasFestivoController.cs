using DFestivosHP3.Core.Interfaces.Servicios;
using DFestivosHP3.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DFestivosHP3.Presentacion.Controllers
{
    [ApiController]
    [Route("api/diasfestivos")]
    public class DiasFestivoController : ControllerBase
    {
        private readonly IFestivoServicio _festivoServicio;

        public DiasFestivoController(IFestivoServicio festivoServicio)
        {
            _festivoServicio = festivoServicio;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Festivo>>> ObtenerTodos()
        {
            var festivos = await _festivoServicio.ObtenerTodos();
            return Ok(festivos);
        }
    }
}

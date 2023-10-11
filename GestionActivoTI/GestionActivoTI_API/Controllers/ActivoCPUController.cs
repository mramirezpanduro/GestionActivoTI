using GestionActivoTI_API.Datos;
using GestionActivoTI_API.Modelos.Activos;
using GestionActivoTI_API.Modelos.DTO.ActivosDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace GestionActivoTI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivoCPUController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ActivoCPUDTO>> ListarActivosCPUs()
        {
            return Ok(GestionActivoStore.listaCPU);

        }

        [HttpGet("int: id")]
        public ActionResult<ActivoCPUDTO> ObtenerActivoCPU(int id)
        {
            return Ok(GestionActivoStore.listaCPU.FirstOrDefault(x => x.Id == id));
        }

    }
}

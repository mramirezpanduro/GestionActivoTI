using GestionActivoTI_API.DTO.ActivosDTO;
using GestionActivoTI_API.Modelos.Activos;
using Microsoft.AspNetCore.Http;
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
            List<ActivoCPUDTO> activos = new List<ActivoCPUDTO>();

            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                ActivoCPUDTO activo = new ActivoCPUDTO
                {
                    Id = rand.Next(1000), // Valor aleatorio para Id
                    NroPuertoUSB3 = rand.Next(1, 11), // Valor aleatorio entre 1 y 10
                    NroPuertoUSB2 = rand.Next(1, 11), // Valor aleatorio entre 1 y 10
                    EsTorre = rand.Next(2) == 0, // Valor booleano aleatorio (true o false)
                    EsRackeable = rand.Next(2) == 0, // Valor booleano aleatorio (true o false)
                    // Campos heredados de ClaseBase
                    Nuevo = rand.Next(2) == 0,
                    Operativo = rand.Next(2) == 0,
                    TieneRed = rand.Next(2) == 0,
                    CodigoInventario = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                    DireccionIP = new string(Enumerable.Repeat("0123456789.", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                    Marca = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                    Modelo = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                    Serie = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                    Color = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                };

                activos.Add(activo);
            }

            return Ok(activos);
        }


        [HttpGet("id:int")]
        public ActionResult<ActivoCPUDTO> ObtenerActivoCPUsxId(int Id)
        {
            if (Id < 1)
                return BadRequest();

            ActivoCPUDTO activoSeleccionado = null;

            if (activoSeleccionado == null)
                return NotFound();

            Random rand = new Random();

            return Ok(new ActivoCPUDTO
            {
                Id = rand.Next(1000), // Valor aleatorio para Id
                NroPuertoUSB3 = rand.Next(1, 11), // Valor aleatorio entre 1 y 10
                NroPuertoUSB2 = rand.Next(1, 11), // Valor aleatorio entre 1 y 10
                EsTorre = rand.Next(2) == 0, // Valor booleano aleatorio (true o false)
                EsRackeable = rand.Next(2) == 0, // Valor booleano aleatorio (true o false)
                                                 // Campos heredados de ClaseBase
                Nuevo = rand.Next(2) == 0,
                Operativo = rand.Next(2) == 0,
                TieneRed = rand.Next(2) == 0,
                CodigoInventario = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                DireccionIP = new string(Enumerable.Repeat("0123456789.", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                Marca = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                Modelo = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                Serie = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
                Color = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 15).Select(s => s[rand.Next(s.Length)]).ToArray()),
            });
        }

    }
}

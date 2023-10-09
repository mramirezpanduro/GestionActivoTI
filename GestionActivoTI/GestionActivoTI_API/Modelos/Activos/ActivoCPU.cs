using GestionActivoTI_API.Modelos.ClasesBases;
using Microsoft.AspNetCore.Components.Web;

namespace GestionActivoTI_API.Modelos.Activos
{
    public class ActivoCPU : ClaseBaseActivo
    {
        public int NroPuertoUSB3 { get; set; }

        public int NroPuertoUSB2 { get; set; }

        public bool EsTorre { get; set; }

        public bool EsRackeable { get; set; }


    }
}

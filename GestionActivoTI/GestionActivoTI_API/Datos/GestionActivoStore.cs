using GestionActivoTI_API.Modelos.DTO.ActivosDTO;

namespace GestionActivoTI_API.Datos
{
    public static class GestionActivoStore
    {
        public static List<ActivoCPUDTO> listaCPU = new List<ActivoCPUDTO>
        {
             new ActivoCPUDTO { Id = 1, Nuevo = true, DireccionIP = "192.168.1.242", TieneRed = true, CodigoInventario = "Codigo Nro 1" , Color = "Negro", Marca ="Generico", EsTorre = true, EsRackeable = false, Modelo = "Generico", Operativo=true, NroPuertoUSB2=4, NroPuertoUSB3 =2},
                new ActivoCPUDTO { Id = 2, Nuevo = true, DireccionIP = "192.168.1.241", TieneRed = true, CodigoInventario = "Codigo Nro 2",Color = "Plomo", Marca ="Generico", EsTorre = true, EsRackeable = false, Modelo = "Generico", Operativo=true, NroPuertoUSB2=4, NroPuertoUSB3 =2 }

        };
    }
}

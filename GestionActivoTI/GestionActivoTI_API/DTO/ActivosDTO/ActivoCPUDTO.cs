namespace GestionActivoTI_API.DTO.ActivosDTO
{
    public class ActivoCPUDTO
    {
        public int Id { get; set; }

        public int NroPuertoUSB3 { get; set; }

        public int NroPuertoUSB2 { get; set; }

        public bool EsTorre { get; set; }

        public bool EsRackeable { get; set; }

        public bool Nuevo { get; set; }

        public bool Operativo { get; set; }

        public bool TieneRed { get; set; }

        public string CodigoInventario { get; set; }

        public string DireccionIP { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Serie { get; set; }

        public string Color { get; set; }
    }
}

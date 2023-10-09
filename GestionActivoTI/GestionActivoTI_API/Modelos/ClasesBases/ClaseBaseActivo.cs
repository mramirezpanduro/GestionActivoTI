namespace GestionActivoTI_API.Modelos.ClasesBases
{
    public class ClaseBaseActivo : ClaseBase
    {
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

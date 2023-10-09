using Microsoft.EntityFrameworkCore;

namespace GestionActivoTI_API.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}

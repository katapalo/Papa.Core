using Papa.Core.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Papa.Core.EF.EntitiesConfig
{
    public class AccionConfiguration : EntityTypeConfiguration<Accion>
    {
        public AccionConfiguration()
        {
            this.ToTable("Acciones");
        }
    }
}

using Papa.Core.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Papa.Core.EF.EntitiesConfig
{
    public class LogCambioHeadConfiguration : EntityTypeConfiguration<LogCambioHead>
    {
        public LogCambioHeadConfiguration()
        {
            this.ToTable("LogCambioHead");
        }
    }
}

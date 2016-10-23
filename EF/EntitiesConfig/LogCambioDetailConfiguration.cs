using Papa.Core.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Papa.Core.EF.EntitiesConfig
{
    public  class LogCambioDetailConfiguration : EntityTypeConfiguration<LogCambioDetail>
    {
        public LogCambioDetailConfiguration()
        {
            this.ToTable("LogCambioDetail");
        }
    }
}

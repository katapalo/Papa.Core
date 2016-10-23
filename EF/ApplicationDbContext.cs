using Papa.Core.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.DynamicFilters;
using System.Security.Principal;

namespace Papa.Core.EF
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext()
            : base("Papa")
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            
#if DEBUG
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
#endif

        }

        //public IDbSet<Cliente> Cliente { get; set; }
        public IDbSet<LogCambioHead> LogCambioHead { get; set; }
        public IDbSet<LogCambioDetail> LogCambiosDetail { get; set; }
           
        public IDbSet<Accion> Accion { get; set; }
        public IDbSet<Campana> Campana { get; set; }

        private int GetClientId()
        {
            return 1;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //  modelBuilder.Configurations.AddFromAssembly(this.GetType().Assembly);
            //  modelBuilder.Conventions.Add(new SoftDeleteConvention());

            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(18, 2));
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //modelBuilder.Conventions.Remove<ForeignKeyIndexConvention

            //Pruebas de filtros
            modelBuilder.Filter("IsDeleted", (ISoftDelete d) => d.isDeleted, false);
            modelBuilder.Filter("Filter_Multitenant", (Domain.Bases.IEntityBase ent, int ClientId) => ent.ClientId == ClientId, () => GetClientId());

            //modelBuilder.Filter("Notes_CurrentUser", (Note n) => n.PersonID, (ApplicationDbContext ctx) => ctx.CurrentPersonID);

            //modelBuilder.Filter("Notes_CurrentUser", (Accion n) => n.Id, () => GetPersonIDFromPrincipal(System.Threading.Thread.CurrentPrincipal));

        }

        //public override int SaveChanges()
        //{
        //    var auditEntries = ChangeTracker
        //                        .Entries()
        //                        .Where(p => p.State == EntityState.Added || p.State == EntityState.Deleted || p.State == EntityState.Modified)
        //                        .Select(e => new AuditEntry(e, date, principal))
        //                        .ToArray();

        //    return base.SaveChanges();
        //}
    }


}

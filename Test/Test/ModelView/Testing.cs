using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papa.Core.Domain.Entities;
using Papa.Core.EF;
using Papa.Core.Domain.Repositories;
using Papa.Core.Domain.Models;
using Papa.Core.Domain.Utils;

namespace Test
{
    public class Testing
    {
        private ApplicationDbContext ctx { get; set; }
        public Testing()
        {
            ctx = new DbContextFactory().GetDbContext();
        }
        public void filtros ()
        {
            //Accion acc = new Accion();
            //acc.isDeleted = true;
            //var repAcc = new Repository<Accion>(new DbContextFactory());
            //int id = repAcc.Save(acc);

            //var lst = repAcc.Where(r=>true).ToList();

            var res = (from a in ctx.Accion                                           
                       select a.Nombre).ToList();
        }
        public void AutoMapper()
        {
            ModelCampana md = new ModelCampana();
            

            //modelo -> entidad
            md.Nombre = "soy la entidad";
            md.Id = 10;
            md.IdAccion = 20;

            Campana entidad = ObjectMapper.Map<ModelCampana, Campana>(md);

            // entidad -> modelo 
            entidad.Nombre = "soy la entidad";
            entidad.Id = 1;
            entidad.IdAccion = 2;

            md = ObjectMapper.Map<Campana, ModelCampana>(entidad);

        }
    }
}

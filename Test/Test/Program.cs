using Papa.Core.Domain.Repositories;
using Papa.Core.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papa.Core.Domain.Entities;
using System.Data.Entity;
using Papa.Core.Domain.Models;
using Papa.Core.Domain.Interfaces;
using Papa.Core.Domain.Fields;
using Papa.Core.Domain.Bases;
using System.Collections.ObjectModel;
using Test;

//using System.Data.Entity;

namespace Test
{
    public static class prueba
    {
        public static void Uno(IA acc)
        {
            acc.a2 = 3;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            //var rep = new Repository<Prueba>();
            //rep.Add(new Prueba()
            //{
            //    NombreCampo = "hola",
            //    ValorAnterior = "Mariano"
            //});
            //var p = 1;
            //var p1 = rep.Get(1);

            //var rep1 = new Repository<LogCambioHead>();
            //var rep2 = new Repository<LogCambioDetail>();
            //var p1 = rep2.GetAll();
            //var y = rep1.GetAll();
            //var p2 = rep1.db.LogCambioHead.Select(r => new { r.Id, r.Nombre });

            //var p3 = (from a in rep1.db.Prueba1
            //          from b in rep1.db.Prueba2
            //          where a.Id == b.Id
            //          select b).ToList<Prueba2>();

            //var db1 = new ApplicationDbContext();

            //var p = rep1.db.LogCambioHead.Include(x => x.LogCambioDetail).First();



            //var pru = rep1.db.LogCambioHead.Include(n => n.LogCambioDetail).Select(r => new
            //{
            //    r.Nombre,
            //    r.LogCambioDetail
            //}).SingleOrDefault();

            //var x = 2;
            
          //  var g = new GenericRepository<LogCambioHead>(new DbContextFactory());
            //var r1 = g.Get(z => z.Id == 1)

            var ctx = new DbContextFactory().GetDbContext();
            //var n = ctx.LogCambioHead.Where(r => r.Id == 1)
            //        .Include(r => r.LogCambioDetail)
            //        .Select(z =>
            //            new
            //            {
            //                a = z.LogCambioDetail.Select(t => t.ValorActual).FirstOrDefault(),
            //                b = z.LogCambioDetail.Select(t => t.ValorAnterior)
            //            }).ToList();

            //var n1 = (from a in ctx.LogCambioHead
            //          join b in ctx.LogCambiosDetail on a.Id equals b.Id into b_join
            //          from b in b_join.DefaultIfEmpty()
            //          select new
            //          {
            //              a = b.ValorActual,
            //              b = b.ValorAnterior
            //          }).ToList();

            var n2 = (from p4 in ctx.LogCambioHead
                     // let total = p4.LogCambioDetail.Sum(pi => p4.Id)                      
                      where p4.Id == 1
                      select new
                      {
                          p4.Nombre,
                          total = p4.LogCambioDetail.Sum(pi=>p4.Id),
                          total1 = p4.LogCambioDetail.Count()
                      }).ToList();
            var rep3 = new Repository<LogCambioHead>(new DbContextFactory());
            var n3 = (from a in ctx.LogCambioHead
                      join b in ctx.LogCambiosDetail on a.Id equals b.Id
                      group a by b.LogCambioHeadId into g
                      select new
                      {
                          v = g.Key,
                          v1 = g.Count(),
                          v2 = g.Sum(g1 => g1.Id)
                      }).ToList();
            var repLog = new RepositoryLogHead(new DbContextFactory());
            var n4 = repLog.GetLogs();


            
            var repCamp = new Repository<Campana>(new DbContextFactory());            
            var ent1 = new ModelCampana();
            Campana c = new Campana();
            var p2 = (FieldsCampana)c;
             var p1= (FieldsCampana) ent1;
            ICampana i1 = c;
            ICampana i2 = ent1;
            i1.Nombre = "campana-1";
            

            var c1 = new Campana();
            c1.Nombre = "Uno";
            var c2 = new Campana();
            c2.Nombre = "dos";

            FieldsAB fldab = new FieldsAB();
            fldab.a1 = 1;
            fldab.b1 = 2;

            prueba.Uno(fldab);

            Testing test = new Testing();
            //test.filtros();
            test.AutoMapper();

            ent1.Acciones = new Collection<IAccion>();
            ent1.Acciones.Add(new Accion());

            FieldsAB p3 = new FieldsAB();
            
            
            
            

           // var p4 = pru.LogCambioDetail.ToArray();
           //var r2 = rep1.Get(1);
           //r2.Nombre = "Mariano2";
           //var r3 = r2.LogCambioDetail.Where(r => r.LogCambioHeadId == 1).FirstOrDefault();
           //r3.ValorActual = "Yolanda2";
           //rep1.Save(r2);

            //rep1.Add(new LogCambioHead()
            //{
            //    IdEntidad = 1,
            //    FechaCambio = DateTime.UtcNow
            //});

            //using (var db = new ApplicationDbContext())
            //{
            //    db.LogCambioHead.First();
            //}
        }
        
    }
}

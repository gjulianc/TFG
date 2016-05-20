using EFCore;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using TFG.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFData
{
    public class BaseMap:EntityTypeConfiguration<Base>, IRepositoryBases
    {
        protected DbContext ctx = new EFDbContext();

        public BaseMap()
        {
            //Key
            HasKey(t => t.Base_Id);

            //Property
            Property(t => t.Base_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Descripcion);
            Property(t => t.Latitud);
            Property(t => t.Longitud);

            //table
            ToTable("Bases");
        }

        public void DeleteBase(Base _base)
        {
            ctx.Set<Base>().Remove(_base);
            GuardarDatos();
        }

        public List<Base> GetAllBases()
        {
            return ctx.Set<Base>().ToList();
        }

        public Base GetBase(int id)
        {
            return ctx.Set<Base>().Find(id);
        }

        public void GuardarDatos()
        {
            ctx.SaveChanges();
        }

        public void InsertarBase(Base _base)
        {
            ctx.Set<Base>().Add(_base);
            this.GuardarDatos();
        }
    }
}

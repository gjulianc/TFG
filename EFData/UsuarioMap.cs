﻿using EFCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TFG.Contrato;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFData
{
    public class UsuarioMap: EntityTypeConfiguration<Usuario>, IRepositoryUsuarios
    {
        protected EFDbContext ctx = new EFDbContext();        

        public UsuarioMap()
        {
            //Key
            HasKey(t => t.Usuario_Id);

            //Property
            Property(t => t.Usuario_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Nombre);
            Property(t => t.User);
            Property(t => t.Password);

            //table
            ToTable("Usuarios");
        }

        public void DeleteUser(Usuario usuario)
        {
            ctx.Set<Usuario>().Remove(usuario);
            GuardarDatos();
        }

        public  List<Usuario> GetAllUsers()
        {
            return ctx.Set<Usuario>().ToList(); 
        }

        public void GuardarDatos()
        {
            ctx.SaveChanges();
        }

        public void InsertUser(Usuario usuario)
        {
            ctx.Set<Usuario>().Add(usuario);
            this.GuardarDatos();
        }

        public void Login(string usuario, string password)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUser(int id)
        {
            return ctx.Set<Usuario>().Find(id);
        }
    }
}

using AspNetMedicos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AspNetMedicos.DAO
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Cidades> Cidades { get; set; }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<MedicosEspecialidades> MedicosEspecialidades { get; set; }
    }
}
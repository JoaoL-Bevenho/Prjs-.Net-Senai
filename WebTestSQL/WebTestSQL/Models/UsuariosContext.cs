using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebTestSQL.Models
{
    public class UsuariosContext: DbContext
    {
        public UsuariosContext() : base("Usuarios")
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
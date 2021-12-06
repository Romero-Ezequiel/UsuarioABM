using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Models.Entities;

namespace WebApi.Models.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext():base("Conexion"){}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        public DbSet<Usuario> Usuario { get; set; }

    }
}
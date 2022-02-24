using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class _dbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder = configurationBuilder.AddJsonFile("appsettings.json");

            IConfiguration configurationFile = configurationBuilder.Build();
            string conexion = configurationFile.GetConnectionString("conexion");
            optionsBuilder.UseSqlServer(connectionString: conexion);
        }

        public DbSet<rolPersonaModels> RolPersona { get; set; }
        //public DbSet<direccionPersonaModels> direccionPersona { get; set; }
        //public DbSet<telefonoModels> telefonoPersona { get; set; }

        /*
        public _dbContext(DbContextOptions<_dbContext> options):base(options)
        {

        }
        */

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder = configurationBuilder.AddJsonFile("appsettings.json");

            IConfiguration configurationFile = configurationBuilder.Build();
            string conexion = configurationFile.GetConnectionString("conexion");
            optionsBuilder.UseSqlServer(connectionString: conexion);
        }
        */

    }
}

using Microsoft.EntityFrameworkCore;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.Context
{
    public class ProjectContext : DbContext, IContext
    {
        public DbSet<MenuDTO> Menu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=4Estrellas;Integrated security=true;TrustServerCertificate=true;");
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=4Estrellas;Integrated security=true;TrustServerCertificate=true;");
        }
    }
}

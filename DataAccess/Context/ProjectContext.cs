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

        public DbSet<UtilisationDTO> Utilisations { get; set; }

        public DbSet<TablesDTO> Tables { get; set; } // il cree un attribut qui s'apelle tables qui va conteinir un valeur 

        public DbSet<CommandeDTO> Commandes { get; set; }
        public DbSet<CommandesArticlesDTO> CommandesArticles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=4Estrellas;Integrated security=true;TrustServerCertificate=true;");
           // options.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=4Estrellas;Integrated security=true;TrustServerCertificate=true;");
        }

        /****/
        Dictionary<string, List<TablesDTO>> ListOfReservations = new Dictionary<string, List<TablesDTO>>();// TablesDTO ???   Creation d<un Dictionnaire, la Clé va etre string et les valeur vont etre une list de tables. ListOfReservations est le nom du Dic. On l'a instancié avec un contructeur vide



    }
}

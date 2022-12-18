using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO
{
    [Table("T_Commandes")]

    public class CommandeDTO : IDTO
    {
        [Key]
        [Column("IdCommande")]
        public int IdCommande { get; set; }
        
        [Required]
        [Column("IdTable")]
        public int IdTable { get; set; }
        
        
        [Column("NombreClients")]
        [Required]
        
        public int NombreClients { get; set; }

        [Column("NombreArticles")]
        [Required]
        public int NombreArticles { get; set; }

        public List<MenuDTO>? ArticlesCommandes { get; set; }
        
        
        /// <summary>
        /// Crée par Karine // A retravailler, quels parametres sont obligatoires pour creer la commande.
        /// </summary>
        /// <param name="nombreClients"></param>
        /// <param name="nombreArticles"></param>

        public CommandeDTO(int nombreClients,int nombreArticles)
        {
            this.NombreClients = nombreClients;
            this.NombreArticles = nombreArticles;
        }
    }
}

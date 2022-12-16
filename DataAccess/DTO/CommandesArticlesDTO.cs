using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO
{
    [Table("T_CommandesArticles")]   
    public class CommandesArticlesDTO : IDTO
    {
        [Column("IdCA")]
        [Key]

        public int IdCA { get; set; }

        [Column("IdCommande")]
        [ForeignKey("IdCommande")]

        public int IdCommande { get; set; }

        [Column("IdArticle")]
        [ForeignKey("IdArticle")]

        public int IdArticle { get; set; }

        [Column("Quantite")]
        [Required]
        public int Quantite { get; set; }
    }
}

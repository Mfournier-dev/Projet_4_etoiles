using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crée par Karine
namespace Projet_4_etoiles.DataAccess.DTO;

[Table("T_CommandesArticles")]   
public class CommandesArticlesDTO : IDTO
{
    [Key]
    [Column("IdCA")]
    public int IdCA { get; set; }

    [Required]
    [Column("IdArticle")]
   
    public int IdArticle { get; set; }

    [Required]
    [Column("IdCommande")]    
    public int IdCommande { get; set; }

    [Required]
    [Column("Quantite")]       
    public int Quantite { get; set; }

    [ForeignKey("IdArticle")]
    public MenuDTO Article { get; set; }

    [ForeignKey("IdCommande")]
    public CommandeDTO Commande { get; set; }

    public CommandesArticlesDTO() 
    { 
    
    }
    public CommandesArticlesDTO(int articleId, int commandeId, int quantite) 
    {
        this.IdArticle = articleId;
        this.IdCommande = commandeId;
        this.Quantite = quantite;
                  
    }
}

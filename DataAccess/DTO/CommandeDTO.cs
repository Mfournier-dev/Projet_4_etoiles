﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO;

[Table("T_Commandes")]
public class CommandeDTO : IDTO
{
    [Column("IdCommande")]
    [Key]
    public int IdCommande { get; set; }
    
    [Required]
    [Column("IdTable")]
    public int IdTable { get; set; }

    [Required]
    [Column("NombreClients")]   
    public int NombreClients { get; set; }

    
   

    public List<CommandesArticlesDTO> ArticlesCommandes { get; set; }

    [ForeignKey("IdTable")]
    public TablesDTO Table { get; set; }
    
    
    /// <summary>
    /// Crée par Karine // A retravailler, quels parametres sont obligatoires pour creer la commande.
    /// </summary>
    /// <param name="nombreClients"></param>
    /// <param name="nombreArticles"></param>

    public CommandeDTO(int idTable,int nombreClients)
    {
        this.IdTable = idTable;
        this.NombreClients = nombreClients;
        
    }

    public int GetId()
    {
        return this.IdCommande;
    }
}

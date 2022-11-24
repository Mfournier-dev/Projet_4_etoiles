using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO;

[Table("T_Table")]   // nom de la Table en DB
public class TablesDTO : IDTO 
{
    [Column("IdTable")]
    [Key]
    public int IdTable { get; set; }

    [Column("QuantiteClients")]
    [Required]
    public int QuantiteClients { get; set; }

    [Column("MinimumClients")]
    [Required]
    public int MinimumClients { get; set; }

    [Column("Statut")]
    [Required]
    [StringLength(15)]
    public string? Statut { get; set; }

    public TablesDTO(int IdTable, int QuantiteClients, int MinimumClients, string Statut)
    {
        this.IdTable = IdTable;
        this.QuantiteClients = QuantiteClients;
        this.MinimumClients = MinimumClients;
        this.Statut = Statut;
    }

}




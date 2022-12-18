using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO
{
    [Table("T_Utilisation")]
    public class UtilisationDTO : IDTO
    {
        [Column("IdUtilisation")]
        [Key]
        public int IdUtilisation { get; set; }

        [Column("NombreClients")]
        [Required]
        public int NombreClients { get; set; }

        [Column("IdTable")]
        [Required]
        [ForeignKey("IdTable")]
        public int IdTable { get; set; }

        [Column("NomReservation")]
        [StringLength(64)]
        public string? NomReservation { get; set; }

        [Column("NumeroTelephone")]
        [StringLength(16)]
        public string? NumeroTelephone { get; set; }

        [Column("DateReservation")]
        [Required]
        public DateTime DateReservation { get; set; }

        [Column("HeureReservation")]
        [Required]
        public DateTime HeureReservation { get; set; }

        public List<TablesDTO> Tables { get; set; }
        public UtilisationDTO() {
            
        }

        public UtilisationDTO(int nombreClients,
                              int idTable,
                              DateTime dateReservation,
                              DateTime heureReservation,
                              string? nomReservation = null,
                              string? numeroTelephone = null)
        {
            this.NombreClients = nombreClients;
            this.IdTable = idTable;
            this.HeureReservation = heureReservation;
            this.DateReservation = dateReservation;
            this.NomReservation = nomReservation;
            this.NumeroTelephone = numeroTelephone;


        }
    }
}

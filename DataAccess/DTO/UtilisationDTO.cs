using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO
{
    [Table("UtilisationTables")]
    public class UtilisationDTO : IDTO
    {
        [Column("IdUtilisation")]
        [Key]
        public int IdUtilisation { get; set; }

        [Column("NombresPersonnes")]
        [Required]
        public int NombresPersonnes { get; set; }

        [Column("IdTable")]
        [Required]
        public int IdTable { get; set; }

        [Column("NomReservation")]
        [StringLength(64)]
        public string? NomReservation { get; set; }

        [Column("NomTelephone")]
        [StringLength(16)]
        public string? NumeroTelephone { get; set; }

        [Column("DateReservation")]
        public DateTime? DateReservation { get; set; }

        [Column("HeureReservation")]
        [Required]
        public TimeOnly HeureReservation { get; set; }

        //public List<TableDTO> Tables { get; set; }

        public UtilisationDTO(int nombrePersonnes,
                              int idTable,
                              TimeOnly heureReservation,
                              string? nomReservation = null,
                              string? numeroTelephone = null,
                              DateTime? dateReservation = null)
        {
            this.NombresPersonnes = nombrePersonnes;
            this.IdTable = idTable;
            this.HeureReservation = heureReservation;
            this.NomReservation = nomReservation;
            this.NumeroTelephone = numeroTelephone;
            this.DateReservation = dateReservation;

        }
    }
}

using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DAO;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.Business.Services
{
    public class UtilisationService
    {
        private UtilisationDAO utilisationDAO;

        public UtilisationService(ProjectContext appContext)
        {
            this.utilisationDAO = new UtilisationDAO(appContext);
        }

        public UtilisationDTO CreateReservation(int nombreClients, int idTable, string? nomReservation, string? numeroTelephone, DateTime? dateReservation, DateTime heurereservation)
        {
            UtilisationDTO utilisation = new UtilisationDTO(nombreClients, idTable, heurereservation, nomReservation, numeroTelephone, dateReservation);
            this.utilisationDAO.Create(utilisation);
            return utilisation;
        }



    }
}

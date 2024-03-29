﻿using Projet_4_etoiles.DataAccess.Context;
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

        public List<UtilisationDTO> GetAllUtilisations()
        {
            return this.utilisationDAO.GetAll();
        }

        public UtilisationDTO CreateUtilisation(int nombreClients, int idTable, DateTime dateReservation, DateTime heurereservation, string? nomReservation, string? numeroTelephone)
        {
            UtilisationDTO utilisation = new UtilisationDTO(nombreClients, idTable, dateReservation, heurereservation, nomReservation, numeroTelephone);
            this.utilisationDAO.Create(utilisation);
            return utilisation;
        }

        public UtilisationDTO ModifyUtilisation(UtilisationDTO utilisation)
        {
            return this.utilisationDAO.Update(utilisation);
        }

        public UtilisationDTO DeleteUtilisation(UtilisationDTO utilisation) 
        {
            return this.utilisationDAO.Delete(utilisation);
        }
    }
}

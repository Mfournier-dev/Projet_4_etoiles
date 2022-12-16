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
    public class CommandeService : IService
    {
        private CommandeDAO commandeDAO;

        public CommandeService(ProjectContext appContext)
        {
            this.commandeDAO = new CommandeDAO(appContext);
        }

// constructeur prend les parametres obligatoires, les memes que le DTO.
        public CommandeDTO CreateCommande(int nombreClients, List<MenuDTO> articlesCommandes)
        {
            CommandeDTO commande = new CommandeDTO(nombreClients, articlesCommandes, articlesCommandes.Count());
            this.commandeDAO.Create(commande);
            return commande;
        }
    }
}

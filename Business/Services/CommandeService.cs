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
        public CommandeDTO CreateCommande(int idTable,int nombreClients)
        {
            CommandeDTO commande = new CommandeDTO(idTable,nombreClients);
            this.commandeDAO.Create(commande);
            return commande;
        }

        public CommandeDTO DeleteCommande(CommandeDTO commande) 
        { 
            return this.commandeDAO.Delete(commande);
        }

        public List<CommandeDTO> GetAllCommandes()
        {
            return this.commandeDAO.GetAll();
        }
    }
}

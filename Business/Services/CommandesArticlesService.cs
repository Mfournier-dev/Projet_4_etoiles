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
    public class CommandesArticlesService
    {
        private CommandesArticlesDAO commandesArticlesDAO;

        public CommandesArticlesService(ProjectContext context) 
        { 
            this.commandesArticlesDAO = new CommandesArticlesDAO(context);
        }

        public List<MenuDTO> GetAllArticlesForCommande(int commandeId) 
        {
            return this.commandesArticlesDAO.GetAllArticlesForCommande(commandeId);
        }
        
        public CommandesArticlesDTO CreateNewCommandeArticleLink(int articleId, int commandeId) 
        {
            CommandesArticlesDTO commandeArticlesDTO = new CommandesArticlesDTO(articleId,commandeId);//,quantite);
            this.commandesArticlesDAO.Create(commandeArticlesDTO);
            return commandeArticlesDTO;
        }

        public CommandesArticlesDTO DeleteCommandeArticleLink(int articleId,int commandeId) 
        {
            return this.commandesArticlesDAO.Delete(this.commandesArticlesDAO.GetByCommandeAndArticles(articleId,commandeId));
        }
    
    }
}

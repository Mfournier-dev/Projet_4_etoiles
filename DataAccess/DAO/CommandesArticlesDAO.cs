using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO
{
    public class CommandesArticlesDAO : IDAO<CommandesArticlesDTO> 
    {
        private ProjectContext _projectContext;

        public CommandesArticlesDAO(ProjectContext projectContext)
        {
            this._projectContext = projectContext;
        }

        public CommandesArticlesDTO GetById(int id)
        {
            return this._projectContext.CommandesArticles.Where(commande => commande.IdCommande == id).Single();
            //pas certaine si necessaire. Attendre explications du prof, doit retourner une liste d'articles, pas une seule ligne seulement.
        }

        public List<CommandesArticlesDTO> GetAll()
        {
            return this._projectContext.CommandesArticles.ToList();
            //retourne DTO Commande
        }

        public CommandesArticlesDTO Update(CommandesArticlesDTO commande)
        {
            //TODO: Retravailler delete, pour que seul un article est updaté de la commande, pas la commande au complet.
            this._projectContext.CommandesArticles.Update(commande);
            this._projectContext.SaveChanges();
            return commande;
        }

        public CommandesArticlesDTO Delete(CommandesArticlesDTO commande)
        {
           //TODO: Retravailler delete, pour que seul un article est supprimé de la commande, pas la commande au complet.
            this._projectContext.CommandesArticles.Remove(commande);
            this._projectContext.SaveChanges();
            return commande;
        }


    }
}

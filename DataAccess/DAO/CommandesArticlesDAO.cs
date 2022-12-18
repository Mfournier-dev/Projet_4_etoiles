using Microsoft.EntityFrameworkCore;
using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO
{
    public class CommandesArticlesDAO
    {
        private ProjectContext context;

        public CommandesArticlesDAO(ProjectContext context)
        {
            if (context is null)
                context = new ProjectContext();

            this.context = context;
        }

        public CommandesArticlesDTO GetByCommandeAndArticles(int commandeId,int articleId)
        {
            return this.context.CommandesArticles.Where(comArt => comArt.IdCommande == commandeId && comArt.IdArticle == articleId).Single();
           
        }

        public CommandesArticlesDTO Create(CommandesArticlesDTO commandeArticle)
        {
            this.context.CommandesArticles.Add(commandeArticle);
            this.context.SaveChanges();
            return commandeArticle;
        }

        //public CommandesArticlesDTO Update(CommandesArticlesDTO commande)
        //{
        //    //TODO: Retravailler delete, pour que seul un article est updaté de la commande, pas la commande au complet.
        //    this._projectContext.CommandesArticles.Update(commande);
        //    this._projectContext.SaveChanges();
        //    return commande;
        //}

        public CommandesArticlesDTO Delete(CommandesArticlesDTO commande)
        {
           //TODO: Retravailler delete, pour que seul un article est supprimé de la commande, pas la commande au complet.
            this.context.CommandesArticles.Remove(commande);
            this.context.SaveChanges();
            return commande;
        }

        public List<MenuDTO> GetAllArticlesForCommande(int commandeId) 
        { 
            List<CommandesArticlesDTO> commandeArticlesLinks = this.context.CommandesArticles
            .Where(comArt => comArt.IdCommande == commandeId)
            .Include(comArt => comArt.Article)
            .ToList();

            List<MenuDTO> articlesList = new List<MenuDTO>();

            foreach(CommandesArticlesDTO comArticleLinks in commandeArticlesLinks) 
            { 
                MenuDTO article = comArticleLinks.Article;
                if (!articlesList.Contains(article)) 
                { 
                    articlesList.Add(article);
                }
            }
            return articlesList;
        }


    }
}

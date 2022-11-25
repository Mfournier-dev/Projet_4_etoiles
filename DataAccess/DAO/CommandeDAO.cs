using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO
{
    public class CommandeDAO : IDAO<CommandeDTO>
    {
        private ProjectContext _projectContext;

        public CommandeDAO(ProjectContext projectContext) 
        { 
            this._projectContext = projectContext;
        }

        public CommandeDTO GetById(int id) 
        {
            return this._projectContext.Commandes.Where(commande => commande.IdCommande == id).Single();
            //retourne DTO Commande
        }

        public List<CommandeDTO> GetAll()
        {
            return this._projectContext.Commandes.ToList();
            //retourne DTO Commande
        }

        public CommandeDTO Create(CommandeDTO newCommande)
        {
            this._projectContext.Commandes.Add(newCommande);
            this._projectContext.SaveChanges();
            return newCommande;
        }

        public CommandeDTO Update(CommandeDTO commande)
        {
            this._projectContext.Commandes.Update(commande);
            this._projectContext.SaveChanges();
            return commande;
        }

        public CommandeDTO Delete(CommandeDTO commande)
        {
            this._projectContext.Commandes.Remove(commande);
            this._projectContext.SaveChanges();
            return commande;
        }
    }
}

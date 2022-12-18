using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO
{
    public class CommandeDAO 
    {
        private ProjectContext context;

        public CommandeDAO(ProjectContext context) 
        {
            if(context is null) 
            { 
                context = new ProjectContext();
            }
            this.context = context;
            
            
        }

        public CommandeDTO GetById(int id) 
        {
            return this.context.Commandes.Where(commande => commande.IdCommande == id).Single();
            //retourne DTO Commande
        }

        //public List<CommandeDTO> GetAll()
        //{
        //    return context.Commandes.ToList();
            
            
        //}

        public CommandeDTO Create(CommandeDTO newCommande)
        {
            this.context.Commandes.Add(newCommande);
            this.context.SaveChanges();
            return newCommande;
        }

        public CommandeDTO Update(CommandeDTO commande)
        {
            this.context.Commandes.Update(commande);
            this.context.SaveChanges();
            return commande;
        }

        public CommandeDTO Delete(CommandeDTO commande)
        {
            this.context.Commandes.Remove(commande);
            this.context.SaveChanges();
            return commande;
        }
    }
}

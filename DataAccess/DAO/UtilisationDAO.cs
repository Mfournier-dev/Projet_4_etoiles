using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO
{
    public class UtilisationDAO : IDAO<UtilisationDTO>
    {

        private ProjectContext _context;

        public UtilisationDAO(ProjectContext? context = null)
        {
            if (context is null)
                context = new ProjectContext();

            this._context = context;
        }

        List<UtilisationDTO> IDAO<UtilisationDTO>.GetAll()
        {
            return this._context.Utilisations.ToList();
        }

        UtilisationDTO IDAO<UtilisationDTO>.GetById(int id)
        {
            return this._context.Utilisations.Where(utilisation => utilisation.IdUtilisation == id).Single();
        }

        public UtilisationDTO Create(UtilisationDTO newUtilisation)
        {
            this._context.Utilisations.Add(newUtilisation);
            this._context.SaveChanges();
            return newUtilisation;
        }

        public UtilisationDTO Update(UtilisationDTO utilisation)
        {
            this._context.Utilisations.Update(utilisation);
            this._context.SaveChanges();
            return utilisation;
        }

        public UtilisationDTO Delete(UtilisationDTO utilisation)
        {
            this._context.Utilisations.Remove(utilisation);
            this._context.SaveChanges();
            return utilisation;
        }

    }
}

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

        private ProjectContext context;

        public UtilisationDAO(ProjectContext? context = null)
        {
            if (context is null)
                context = new ProjectContext();

            this.context = context;
        }

        List<UtilisationDTO> IDAO<UtilisationDTO>.GetAll()
        {
            return this.context.Utilisations.ToList();
        }

        UtilisationDTO IDAO<UtilisationDTO>.GetById(int id)
        {
            return this.context.Utilisations.Where(utilisation => utilisation.IdUtilisation == id).Single();
        }
    }
}

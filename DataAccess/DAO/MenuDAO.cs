using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DAO;

public class MenuDAO : IDAO<MenuDTO>
{
    private ProjectContext context;

    public MenuDAO(ProjectContext? context = null)
    {
        if (context is null)
        {
            context = new ProjectContext();
        }
        this.context = context;
    }

    public List<MenuDTO> GetAll()
    {
        throw new NotImplementedException();
    }

    public MenuDTO GetById(int id)
    {
        throw new NotImplementedException();
    }
}

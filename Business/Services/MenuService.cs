using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DAO;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.Business.Services;

public class MenuService : IService
{
    private MenuDAO menuDAO;

    public MenuService(ProjectContext appContext)
    {
        this.menuDAO = new MenuDAO(appContext);
    }

    public MenuDTO CreateNewMenu(int id, string name, string category, int price)
    {
        MenuDTO menu = new MenuDTO(id, name, category, price);
        this.menuDAO.Create(menu);
        return menu;
    }
}


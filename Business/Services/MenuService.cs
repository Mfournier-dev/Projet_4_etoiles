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
    public List<MenuDTO> GetAllCategories()
    {
        return this.menuDAO.GetAll();
    }
    public MenuDTO CreateNewItem(string name, string categorie, int price)
    {
        MenuDTO newItem = new MenuDTO(name, categorie, price);
        this.menuDAO.Create(newItem);
        return newItem;
    }

    public MenuDTO CreateNewItem( MenuDTO newItem)
    {
        return this.menuDAO.Create(newItem);
    }

    public MenuDTO ModifyItem(MenuDTO newItem)
    {
        return this.menuDAO.Update(newItem);
    }

    public MenuDTO DeleteNewItem(MenuDTO newItem)
    {
        return this.menuDAO.Delete(newItem);
    }
}


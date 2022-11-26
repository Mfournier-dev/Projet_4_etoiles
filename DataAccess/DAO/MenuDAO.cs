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
        return this.context.Menu.ToList();
    }

    public MenuDTO GetById(int id)
    {
        return this.context.Menu.Where(menu => menu.Id == id).Single();
    }

    public MenuDTO Create(MenuDTO newMenu)
    {
        this.context.Menu.Add(newMenu);
        this.context.SaveChanges();
        return newMenu;
    }

    public MenuDTO Update(MenuDTO newMenu)
    {
        this.context.Menu.Update(newMenu);
        this.context.SaveChanges();
        return newMenu;
    }

    public MenuDTO Delete(MenuDTO newMenu)
    {
        this.context.Menu.Remove(newMenu);
        this.context.SaveChanges();
        return newMenu;
    }
}

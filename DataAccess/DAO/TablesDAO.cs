using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Projet_4_etoiles.DataAccess.DAO;
public class TablesDAO : IDAO<TablesDTO>

	// CREATION D'OBJET = Minuscule 
	// FONCTION - METHODE = Majuscule 


{
	private ProjectContext context; // Creant l'attribut context (je vais l'initialiser dans le constructeur)

    public TablesDAO(ProjectContext? context = null) // Constructeur Generique (Il peut recevoir ou non un context)
	{
		if (context is null)
		{
			context = new ProjectContext();
		}
		this.context = context;
		
	}

	public List<TablesDTO> GetAll()
	{
		return this.context.Tables.ToList();
	} 

	public TablesDTO GetById(int id)
	{
		return this.context.Tables.Where(tables => tables.IdTable== id).Single();   // Lambda??
	}

	public TablesDTO CreateTable (TablesDTO newTable)
	{
		this.context.Tables.Add(newTable);
		this.context.SaveChanges();
		return newTable;

	}


    public TablesDTO DeleteTable(TablesDTO tableDelete)
    {
        this.context.Tables.Remove(tableDelete);
        this.context.SaveChanges();
        return tableDelete;

    }

    public TablesDTO UpdateTable(TablesDTO updateTable)
    {
        this.context.Tables.Update(updateTable);
        this.context.SaveChanges();
        return updateTable;

    }



}

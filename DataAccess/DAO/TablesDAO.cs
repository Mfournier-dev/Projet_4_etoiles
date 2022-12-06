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
	private ProjectContext _context; // Creant l'attribut _context (je vais l'initialiser dans le constructeur)

    public TablesDAO(ProjectContext? context = null) // Constructeur Generique (Il peut recevoir ou non un _context)
	{
		if (context is null)
		{
			context = new ProjectContext();
		}
		this._context = context;
		
	}

	public List<TablesDTO> GetAll()
	{
		return this._context.Tables.ToList();
	} 

	public TablesDTO GetById(int id)
	{
		return this._context.Tables.Where(tables => tables.IdTable== id).Single();   // Lambda??
	}

	public TablesDTO CreateTable (TablesDTO newTable)
	{
		this._context.Tables.Add(newTable);
		this._context.SaveChanges();
		return newTable;

	}


    public TablesDTO DeleteTable(TablesDTO tableDelete)
    {
        this._context.Tables.Remove(tableDelete);
        this._context.SaveChanges();
        return tableDelete;

    }

    public TablesDTO UpdateTable(TablesDTO updateTable)
    {
        this._context.Tables.Update(updateTable);
        this._context.SaveChanges();
        return updateTable;

    }



}

using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Projet_4_etoiles.DataAccess.DAO;
public class TablesDAO : IDAO<TablesDTO>
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

	///*************************** MODIFIER APRES LA FORME
    public void GetbyStatut(String Statut)
    {
        foreach(TablesDTO table in GetAll())
		{
			if (table.Statut == Statut){
				
			}
		}   // Lambda??
    }






}

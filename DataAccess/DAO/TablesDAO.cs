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
	// FUNCTION - METHODE = Majuscule 


{
	private ProjectContext context; // Creant l'attribut context (je vais l'initialiser dans le constructeur)



	// Liste Tables
    string[] tablesId = { "Table 01", "Table 02", "Table 03", "Table 04", "Table 05", "Table 06", "Table 07", "Table 08", "Table 09", "Table 10", "Table 11", "Table 12", "Table 13", "Table 14", "Table 15", "Table 16", "Table 17", "Table 18", "Table 19", "Table 20" };
    // Liste Statut
    string[] statutTables = { " Reservé", " Disponiblé" };

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
    /*
	public void GetbyStatut(String Statut)
    {
		(DbSet<UtilisationDTO>).Where




		
		string[] tablesId = { };
		List<TablesDTO> StatusTable = new List<TablesDTO>();

        foreach (TablesDTO table in GetAll())
		{
            	if (table.Statut == Statut){
				tablesId.Add(table);
				return tablesId;

	
            //	adjuntar.StatusTable
            //	return RelatedImageListAttribute table que cumplen con la funcion en el parametro




        }
        //}   // Lambda??
    }
	*/

}

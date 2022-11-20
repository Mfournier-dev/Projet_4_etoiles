using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO;

[Table("T_Articles")]
public class MenuDTO
{
    [Column("Id")]
    [Key]
    public int Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("Category")]
    public string Category { get; set; }

    [Column("Price")]
    public int Price { get; set; }

    public MenuDTO(int id, string name, string category, int price)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
    }
}

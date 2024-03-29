﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess.DTO;

[Table("T_Articles")]
public class MenuDTO : IDTO
{
    [Column("IdArticle")]
    [Key]
    public int Id { get; set; }

    [Column("NomArticle")]
    [Required]
    public string Name { get; set; }

    [Column("Categorie")]
    [Required]
    public string Category { get; set; }

    [Column("Prix")]
    [Required]
    public decimal Price { get; set; }


    public MenuDTO(string name, string category, decimal price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

    public int GetId()
    {
        return this.Id;
    }

    public string ToStringForListView()
    {
        return this.Name;
    }
}

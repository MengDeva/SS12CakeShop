﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS12CarWashing.Models;

public class Item
{
    [Key]
    public Guid ItemId { get; set; }
    [ForeignKey("ItemType")]
    [Display(Name ="Item Type")]
    public Guid ItemTypeId { get; set; }
    [Required]
    [StringLength(50)]
    [Display(Name ="Cake Name")]
    public string ItemName { get; set; }
    public double Price { get; set; }
 
    public bool IsStock { get; set; }
    [Display(Name ="Qty Stock")]
    public int QtyOnHand { get; set; }
    public string Size { get; set; }
    public string Image { get; set; }
    public ItemType ItemType { get; set; }

}

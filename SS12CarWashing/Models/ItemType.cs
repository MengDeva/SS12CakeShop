using System.ComponentModel.DataAnnotations;

namespace SS12CarWashing.Models;

public class ItemType
{
    [Key]
    public Guid ItemTypeId { get; set; }
    [Required]
    [MaxLength(50)]
    [Display(Name = "Category Name")]
    public string ItemTypeName { get; set; }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Index(nameof(SiteId), IsUnique = true)]
public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } 

    public int SiteId { get; set; }

    [ForeignKey(nameof(SiteId))]
    public WasteCollectionSite Site { get; set; } = null!;
}

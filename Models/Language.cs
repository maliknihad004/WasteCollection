
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

[Index(nameof(Code), IsUnique = true)]
public class Language
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    public string Name { get; set; } 

    public ICollection<SiteTranslation> SiteTranslations { get; set; }
        = new List<SiteTranslation>();
}

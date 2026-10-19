
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[PrimaryKey(nameof(SiteId), nameof(LanguageId))]
public class SiteTranslation
{
    public int SiteId { get; set; }

    [ForeignKey(nameof(SiteId))]
    public WasteCollectionSite Site { get; set; } = null!;

    public int LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public Language Language { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;
}

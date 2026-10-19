
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class WasteCollectionSite
{
    [Key]
    public int Id { get; set; }

    public int MunicipalityId { get; set; }

    [ForeignKey(nameof(MunicipalityId))]
    public Municipality Municipality { get; set; }

    public Employee? Employee { get; set; }

    public ICollection<SiteTranslation> Translations { get; set; }
        = new List<SiteTranslation>();
}

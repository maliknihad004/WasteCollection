
using System.ComponentModel.DataAnnotations;

public class Municipality
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    
    public ICollection<WasteCollectionSite> Sites { get; set; }
        = new List<WasteCollectionSite>();
}

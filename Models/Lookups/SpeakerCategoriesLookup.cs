using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerCategories", Schema = "SalesOps")]
    public partial class SpeakerCategoriesLookupModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
    }
}

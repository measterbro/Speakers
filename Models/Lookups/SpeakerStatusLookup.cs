using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerStatus", Schema = "SalesOps")]
    public partial class SpeakerStatusLookupModel
    {
        public int Id { get; set; }
        public string SpeakerStatus { get; set; }
    }
}

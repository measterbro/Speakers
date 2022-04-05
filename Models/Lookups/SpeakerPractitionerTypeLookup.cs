using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerPractitionerType", Schema = "SalesOps")]
    public partial class SpeakerPractitionerTypeLookupModel
    {
        public int Id { get; set; }
        public string PractitionerType { get; set; }
    }
}

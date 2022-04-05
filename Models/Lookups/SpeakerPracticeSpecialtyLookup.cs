using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerPracticeSpecialty", Schema = "SalesOps")]
    public partial class SpeakerPracticeSpecialtyLookupModel
    {
        public int Id { get; set; }
        public string PracticeSpecialty { get; set; }
    }
}

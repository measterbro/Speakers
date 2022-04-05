using System.ComponentModel.DataAnnotations.Schema;

namespace Security2.Models
{
    [Table("SpeakerContractDuration", Schema = "SalesOps")]
    public partial class SpeakerContractDurationLookupModel
    {
        public int Id { get; set; }
        public string Duration { get; set; }
    }
}

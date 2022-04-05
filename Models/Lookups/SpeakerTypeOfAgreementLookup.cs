using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerTypeOfAgreement", Schema = "SalesOps")]
    public partial class SpeakerTypeOfAgreementLookupModel
    {
        public int Id { get; set; }
        public string TypeOfAgreement { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("SpeakerAddressType", Schema = "SalesOps")]
    public partial class SpeakerAddressTypeLookupModel
    {
        public int Id { get; set; }
        public string AddressType { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("Sales_Listing", Schema = "SalesOps")]
    public partial class TerritoryLookupModel
    {
        [Key]
        public int TerritoryId { get; set; }
        public string TerritoryManager { get; set; }
    }
}

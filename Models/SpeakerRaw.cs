using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Security2.Models
{
    [Table("Speakers", Schema = "SalesOps")]
    public partial class SpeakerStatusModel
    {
        [Key]
        public int Id { get; set; }
        public string SpeakerFirstName { get; set; }
        public string SpeakerLastName { get; set; }
        public int? SpeakerStatus { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? TerminationDate { get; set; }
        public bool? TrainingStatus { get; set; }
        public int? TypeOfAgreement { get; set; }
        public string SpeakerAddress { get; set; }
        public int? AddressType { get; set; }
        public string SpeakerEmail { get; set; }
        public string SpeakerInstitution { get; set; }
        public string SpeakerFellowshipEntity { get; set; }
        public bool? NationalSpeaker { get; set; }
        public string Npi { get; set; }
        public int? PractitionerType { get; set; }
        public int? SpeakerPracticeSpecialty { get; set; }
        public int? TerritoryID { get; set; }
        public int? CategoryCD { get; set; }
        public int? CategoryOther { get; set; }
        public int? ContractDuration { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}

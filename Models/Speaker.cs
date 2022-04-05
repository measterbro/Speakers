using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Security2.Models
{
    public partial class SpeakerQuery
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string SpeakerFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string SpeakerLastName { get; set; }

        [Display(Name = "Speaker Status")]
        public string SpeakerStatus { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? TerminationDate { get; set; }

        [Display(Name = "Status")]
        public bool? TrainingStatus { get; set; }

        [Display(Name = "Agreement")]
        public string TypeOfAgreement { get; set; }

        [Display(Name = "Address Type")]
        public string AddressType { get; set; }

        [Display(Name = "Email")]
        public string SpeakerEmail { get; set; }

        [Display(Name = "Institution")]
        public string SpeakerInstitution { get; set; }

        [Display(Name = "Fellowship")]
        public string SpeakerFellowshipEntity { get; set; }

        [Display(Name = "National")]
        public bool? NationalSpeaker { get; set; }

        [Display(Name = "NPI")]
        public string Npi { get; set; }

        [Display(Name = "Practitioner")]
        public string PractitionerType { get; set; }

        [Display(Name = "Speciality")]
        public string SpeakerPracticeSpecialty { get; set; }

        [Display(Name = "Category1")]
        public string CategoryCD { get; set; }
        
        [Display(Name = "Category2")]
        public string CategoryOther { get; set; }

        [Display(Name = "Duration")]
        public string ContractDuration { get; set; }

        [Display(Name = "TM")]
        public string TerritoryManager { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}

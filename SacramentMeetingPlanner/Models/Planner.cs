using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Planner
    {
        public int ID { get; set; }

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Presiding:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string Presiding { get; set; }

        [Display(Name = "Conducting:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string Conducting { get; set; }

        [Display(Name = "Opening Hymn:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Invocation:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string Invocation { get; set; }

        [Display(Name = "Sacrament Hymn:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Sacrament Prayer:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string SacramentPrayer { get; set; }

        [Display(Name = "Speaker #1:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string SpeakerOne { get; set; }

        [Display(Name = "Topic:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string TopicOne { get; set; }

        [Display(Name = "Speaker #2:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string SpeakerTwo { get; set; }

        [Display(Name = "Topic:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string TopicTwo { get; set; }

        [Display(Name = "Speaker #3:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string SpeakerThree { get; set; }

        [Display(Name = "Topic:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string TopicThree { get; set; }

        [Display(Name = "Closing Hymn:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\-0-9\s]*$")]
        [StringLength(50)]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Benediction:")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string Benediction { get; set; }
    }
}
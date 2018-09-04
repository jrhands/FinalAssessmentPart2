namespace FinalAssessmentPart2.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [StringLength(5)]
        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}

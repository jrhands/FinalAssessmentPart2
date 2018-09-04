namespace FinalAssessmentPart2.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }
    }
}

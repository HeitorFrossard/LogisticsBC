namespace LogisticsBCApp.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Driver
    {
        public int DriverId { get; set; }

        [Required]
        [StringLength(30)]
        public string DriverName { get; set; }

        public decimal TotalEarnings { get; set; }
    }
}

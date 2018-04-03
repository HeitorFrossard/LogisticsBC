namespace LogisticsBCApp.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Package
    {
        public int PackageId { get; set; }

        [Required]
        [StringLength(30)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(30)]
        public string Address { get; set; }

        public int AreaId { get; set; }

        public decimal Weight { get; set; }

        public DateTime DeliveryDate { get; set; }

        public bool StatusDelivered { get; set; }
    }
}

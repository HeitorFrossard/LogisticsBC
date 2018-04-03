namespace LogisticsBCApp.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Truck
    {
        public int TruckId { get; set; }

        public decimal MaxLoad { get; set; }

        public decimal CurrentLoad { get; set; }

        public int AreaId { get; set; }

        public int DriverId { get; set; }
    }
}

namespace LogisticsBCApp.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Area
    {
        public int AreaId { get; set; }

        [Required]
        [StringLength(20)]
        public string AreaName { get; set; }
    }
}

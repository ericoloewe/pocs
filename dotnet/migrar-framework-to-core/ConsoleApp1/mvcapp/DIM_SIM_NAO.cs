namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_SIM_NAO")]
    public partial class DIM_SIM_NAO
    {
        [Key]
        [StringLength(10)]
        public string SIM_NAO { get; set; }
    }
}

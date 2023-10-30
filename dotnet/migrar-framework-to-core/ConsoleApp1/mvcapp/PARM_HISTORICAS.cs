namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PARM_HISTORICAS")]
    public partial class PARM_HISTORICAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal DIAS_TRANSACIONAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string STATUS_HISTORICA { get; set; }
    }
}

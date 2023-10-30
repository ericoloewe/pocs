namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_RECEBA_JA")]
    public partial class DIM_RECEBA_JA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IND_RECEBA_JA { get; set; }

        [StringLength(100)]
        public string DESC_RECEBA_JA { get; set; }

        public decimal? DIAS_RECEBA_JA { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.MIX_BANDEIRAS")]
    public partial class MIX_BANDEIRAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal MCC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string SEGMENTO { get; set; }

        public decimal? PCT_VISA { get; set; }

        public decimal? PCT_MC { get; set; }

        public decimal? PCT_ELO { get; set; }

        public decimal? PCT_AMEX { get; set; }

        public decimal? PCT_HIPER { get; set; }

        public decimal? PCT_HIPERCARD { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.MIX_MODALIDADE_REGIONAL")]
    public partial class MIX_MODALIDADE_REGIONAL
    {
        [Key]
        [Column(Order = 0)]
        public decimal MCC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string REGIONAL { get; set; }

        public decimal? PCT_CRED_V_PRES { get; set; }

        public decimal? PCT_CRED_2_6_PRES { get; set; }

        public decimal? PCT_CRED_7_12_PRES { get; set; }

        public decimal? PCT_DEB_V_PRES { get; set; }

        public decimal? PCT_CARNE_PRES { get; set; }

        public decimal? PCT_RECO_PRES { get; set; }

        public decimal? PCT_CRED_V_ECO { get; set; }

        public decimal? PCT_CRED_2_6_ECO { get; set; }

        public decimal? PCT_CRED_7_12_ECO { get; set; }

        public decimal? PCT_DEB_V_ECO { get; set; }

        public decimal? PCT_CARNE_ECO { get; set; }

        public decimal? PCT_RECO_ECO { get; set; }
    }
}

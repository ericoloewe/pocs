namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_CALLCENTER")]
    public partial class ALCADA_CALLCENTER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string CARGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MCC { get; set; }

        public decimal? MDR_BRUTA { get; set; }

        public decimal? TAXA_MIN_DEB { get; set; }

        public decimal? TAXA_MIN_CRED { get; set; }

        public decimal? TAXA_MIN_PARC_2_6 { get; set; }

        public decimal? TAXA_MIN_PARCE_7_12 { get; set; }

        public decimal? TAXA_MIN_CARNE { get; set; }

        public decimal? TAXA_MIN_RECO { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal FATURAMENTO_MIN { get; set; }

        public decimal? FATURAMENTO_MAX { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATA_INSERT { get; set; }

        public decimal? TAXA_MIN_CREDIARIO { get; set; }
    }
}

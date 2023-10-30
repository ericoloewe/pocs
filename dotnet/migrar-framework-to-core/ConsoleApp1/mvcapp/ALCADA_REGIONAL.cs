namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_REGIONAL")]
    public partial class ALCADA_REGIONAL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string CARGO { get; set; }

        [StringLength(50)]
        public string UNIORG_AGENCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string COD_UNIORG_REG { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MCC { get; set; }

        [StringLength(100)]
        public string DESC_REDE { get; set; }

        [StringLength(100)]
        public string DESC_REGIONAL { get; set; }

        public decimal? MDR_BRUTA { get; set; }

        public decimal? TAXA_MIN_DEB { get; set; }

        public decimal? TAXA_MIN_CRED { get; set; }

        public decimal? TAXA_MIN_PARC_2_6 { get; set; }

        public decimal? TAXA_MIN_PARCE_7_12 { get; set; }

        public decimal? TAXA_MIN_CARNE { get; set; }

        public decimal? TAXA_MIN_RECO { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal FATURAMENTO_MIN { get; set; }

        public decimal? FATURAMENTO_MAX { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DATA_INSERT { get; set; }

        public decimal? TAXA_MIN_CREDIARIO { get; set; }
    }
}

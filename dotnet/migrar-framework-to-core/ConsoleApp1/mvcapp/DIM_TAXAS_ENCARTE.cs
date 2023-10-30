namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_TAXAS_ENCARTE")]
    public partial class DIM_TAXAS_ENCARTE
    {
        public DateTime? DATA_INSERT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string SUBRAMO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MCC { get; set; }

        public decimal? TIPO { get; set; }

        [StringLength(50)]
        public string DESC_TIPO { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_MODALIDADE { get; set; }

        public decimal? TAXA { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ATIVO { get; set; }

        public DateTime? DATA_UPDATE { get; set; }
    }
}

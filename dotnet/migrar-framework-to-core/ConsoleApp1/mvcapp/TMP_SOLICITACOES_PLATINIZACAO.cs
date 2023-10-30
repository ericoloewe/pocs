namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SOLICITACOES_PLATINIZACAO")]
    public partial class TMP_SOLICITACOES_PLATINIZACAO
    {
        [Key]
        [Column(Order = 0)]
        public decimal IDBANDEIRA { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal IDPLASTICO { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal IDMODALIDADE { get; set; }

        public decimal? PERCREF { get; set; }
    }
}

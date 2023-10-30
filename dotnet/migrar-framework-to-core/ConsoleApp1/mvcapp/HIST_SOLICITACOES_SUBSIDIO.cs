namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_SUBSIDIO")]
    public partial class HIST_SOLICITACOES_SUBSIDIO
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_TAXA { get; set; }

        public decimal? PCT_SUBSIDIO { get; set; }

        public decimal? DESC_SUBSIDIO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_MDR")]
    public partial class HIST_SOLICITACOES_MDR
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [StringLength(100)]
        public string LOGIN { get; set; }

        [StringLength(100)]
        public string PERFIL { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_TAXA { get; set; }

        public decimal? MDR_LIQUIDA { get; set; }

        public decimal? BAI { get; set; }

        public decimal? MOL { get; set; }

        public decimal? ID_FORMULA { get; set; }

        public decimal? VALOR_FORMULA { get; set; }
    }
}

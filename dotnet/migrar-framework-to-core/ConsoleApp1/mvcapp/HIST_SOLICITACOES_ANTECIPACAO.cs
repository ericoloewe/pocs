namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_ANTECIPACAO")]
    public partial class HIST_SOLICITACOES_ANTECIPACAO
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDEM { get; set; }

        public short? IND_ANTECIPACAO { get; set; }

        public decimal? ANTEC_PORC_VOLUME { get; set; }

        public decimal? ANTEC_SPREAD { get; set; }

        public decimal? ANTEC_PORC_CDI { get; set; }

        public decimal? ANTEC_RECEITA { get; set; }

        public decimal? ATIVO { get; set; }

        public bool? ANTEC_AUTO { get; set; }

        public decimal? ANTEC_TAXA { get; set; }

        public decimal? PRAZO_MEDIO { get; set; }

        public decimal? ANTEC_AUTO_TAXA { get; set; }
    }
}

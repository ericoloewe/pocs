namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_TECNOLOGIAS")]
    public partial class HIST_SOLICITACOES_TECNOLOGIAS
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDEM { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_TECNOLOGIA { get; set; }

        public decimal? NUMERO { get; set; }

        public decimal? VALOR_ALUGUEL { get; set; }
    }
}

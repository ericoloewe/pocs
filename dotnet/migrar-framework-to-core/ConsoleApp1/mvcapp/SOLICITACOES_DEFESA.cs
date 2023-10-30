namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SOLICITACOES_DEFESA")]
    public partial class SOLICITACOES_DEFESA
    {
        public DateTime? DATA_DEFESA { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDEM { get; set; }

        public decimal? ESTADO { get; set; }

        public string DEFESA_COMERCIAL { get; set; }

        public string TEXTO_MESA { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SOLICITACOES_TAXAS_SEM_DESC")]
    public partial class SOLICITACOES_TAXAS_SEM_DESC
    {
        public DateTime DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal IND_ECOMMERCE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_BANDEIRA { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal COD_MODALIDADE { get; set; }

        public decimal TAXA { get; set; }
    }
}

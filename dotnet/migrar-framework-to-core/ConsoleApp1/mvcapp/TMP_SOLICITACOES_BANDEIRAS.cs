namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SOLICITACOES_BANDEIRAS")]
    public partial class TMP_SOLICITACOES_BANDEIRAS
    {
        [Key]
        public decimal COD_BANDEIRA { get; set; }

        public decimal? FATURAMENTO { get; set; }
    }
}

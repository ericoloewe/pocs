namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SOLICITACOES_FATURAMENTOS")]
    public partial class TMP_SOLICITACOES_FATURAMENTOS
    {
        [Key]
        [Column(Order = 0)]
        public decimal COD_TECNOLOGIA { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_MODALIDADE { get; set; }

        public decimal? PCT_FATURAMENTO { get; set; }
    }
}

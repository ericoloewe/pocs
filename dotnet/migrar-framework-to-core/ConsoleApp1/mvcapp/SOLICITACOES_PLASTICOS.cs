namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SOLICITACOES_PLASTICOS")]
    public partial class SOLICITACOES_PLASTICOS
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_BANDEIRA { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_PLASTICO { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal COD_MODALIDADE { get; set; }

        public decimal? PERC_PLASTICO { get; set; }

        public decimal? PERC_REF { get; set; }

        public DateTime DT_INSERT { get; set; }

        public DateTime DT_UPDATE { get; set; }
    }
}

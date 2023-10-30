namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SOLICITACOES_TAXASAPROV")]
    public partial class TMP_SOLICITACOES_TAXASAPROV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string COD_TIPO_TAXA { get; set; }

        public decimal? IND_ECOMMERCE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_BANDEIRA { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_MODALIDADE { get; set; }

        public decimal? TAXA { get; set; }
    }
}

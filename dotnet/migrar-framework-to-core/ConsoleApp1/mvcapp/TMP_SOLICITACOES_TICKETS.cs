namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SOLICITACOES_TICKETS")]
    public partial class TMP_SOLICITACOES_TICKETS
    {
        [Key]
        public decimal COD_MODALIDADE { get; set; }

        public decimal? TICKET { get; set; }
    }
}

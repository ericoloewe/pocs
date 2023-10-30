namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.VW_SOLTAXA_CONC_MAX")]
    public partial class VW_SOLTAXA_CONC_MAX
    {
        [Key]
        public decimal ID_SOLICITACAO { get; set; }

        public decimal? MAX_TAXA { get; set; }
    }
}

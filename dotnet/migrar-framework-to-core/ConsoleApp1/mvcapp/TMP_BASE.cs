namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_BASE")]
    public partial class TMP_BASE
    {
        [Key]
        public decimal ID_SOLICITACAO { get; set; }

        public DateTime? DATA_SOLICITACAO { get; set; }

        public DateTime? DATA_FIM { get; set; }
    }
}

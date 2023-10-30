namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.COMERCIAIS_GETNET")]
    public partial class COMERCIAIS_GETNET
    {
        public decimal? MATRICULA { get; set; }

        [Key]
        [StringLength(100)]
        public string LOGIN { get; set; }

        [StringLength(200)]
        public string NOME { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [StringLength(100)]
        public string REGIONAL { get; set; }
    }
}

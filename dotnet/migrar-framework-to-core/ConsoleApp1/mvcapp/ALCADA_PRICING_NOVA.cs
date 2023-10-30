namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_PRICING_NOVA")]
    public partial class ALCADA_PRICING_NOVA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_SEGMENTO { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        public decimal? VALOR { get; set; }

        public decimal ID_FORMULA { get; set; }

        public DateTime DATA_INSERT { get; set; }
    }
}

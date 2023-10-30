namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.FATURAMENTO_MIN_MES")]
    public partial class FATURAMENTO_MIN_MES
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_AREA { get; set; }

        [StringLength(50)]
        public string AREA { get; set; }

        public decimal? FATURAMENTO { get; set; }

        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_INSERT { get; set; }
    }
}

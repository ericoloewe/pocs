namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_PRICING_FORMULA")]
    public partial class ALCADA_PRICING_FORMULA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(100)]
        public string VAL { get; set; }

        [StringLength(100)]
        public string TEXTO { get; set; }

        public bool? ACTIVE { get; set; }

        public DateTime? DATA_INSERT { get; set; }

        public decimal? COD_TIPO { get; set; }

        [StringLength(30)]
        public string TIPO { get; set; }
    }
}

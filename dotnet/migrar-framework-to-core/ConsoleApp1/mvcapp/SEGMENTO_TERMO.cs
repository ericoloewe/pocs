namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SEGMENTO_TERMO")]
    public partial class SEGMENTO_TERMO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal SEGMENTOID { get; set; }

        public decimal REQUERTERMO { get; set; }

        public decimal ATIVA { get; set; }

        public virtual DIM_SEGMENTOS DIM_SEGMENTOS { get; set; }
    }
}

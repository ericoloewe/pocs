namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_PERIODOS")]
    public partial class DIM_PERIODOS
    {
        public decimal ID { get; set; }

        public decimal? NUM_DIAS { get; set; }

        public decimal? NUM_MESES { get; set; }

        [StringLength(200)]
        public string NOME { get; set; }

        public bool? ISDEFAULT { get; set; }

        public bool? ATIVO { get; set; }

        public DateTime? DATA_UPDATE { get; set; }
    }
}

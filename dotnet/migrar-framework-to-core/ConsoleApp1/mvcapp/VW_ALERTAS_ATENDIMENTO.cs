namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.VW_ALERTAS_ATENDIMENTO")]
    public partial class VW_ALERTAS_ATENDIMENTO
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        public DateTime? DATA_SOLICITACAO { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        [StringLength(100)]
        public string LOGIN { get; set; }

        [StringLength(100)]
        public string REGIONAL { get; set; }

        [StringLength(100)]
        public string AREA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(120)]
        public string MCC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(120)]
        public string SEGMENTO { get; set; }
    }
}

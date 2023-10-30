namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_TECNOLOGIAS")]
    public partial class DIM_TECNOLOGIAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_TIPO_TECNOLOGIA { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_TECNOLOGIA { get; set; }

        [StringLength(100)]
        public string TIPO_TECNOLOGIA { get; set; }

        public decimal? ALUGUEL { get; set; }

        public DateTime? DATA_INSERT { get; set; }

        public bool? EDITABLE { get; set; }

        public bool? ATIVO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_FERIADOS")]
    public partial class DIM_FERIADOS
    {
        [Key]
        [Column(Order = 0)]
        public DateTime DIA { get; set; }

        [StringLength(400)]
        public string DESCRICAO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_INSERT { get; set; }
    }
}

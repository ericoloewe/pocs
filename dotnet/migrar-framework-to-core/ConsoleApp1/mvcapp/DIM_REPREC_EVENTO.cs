namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_REPREC_EVENTO")]
    public partial class DIM_REPREC_EVENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_DIM_REPREC_EVENTO { get; set; }

        [StringLength(150)]
        public string DESCRICAO { get; set; }
    }
}

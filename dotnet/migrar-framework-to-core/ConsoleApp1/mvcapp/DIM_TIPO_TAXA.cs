namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_TIPO_TAXA")]
    public partial class DIM_TIPO_TAXA
    {
        [Key]
        [StringLength(3)]
        public string COD_TIPO_TAXA { get; set; }

        [StringLength(100)]
        public string DESC_TIPO_TAXA { get; set; }

        [StringLength(50)]
        public string SHORTNAME { get; set; }

        public bool? ATIVO { get; set; }
    }
}

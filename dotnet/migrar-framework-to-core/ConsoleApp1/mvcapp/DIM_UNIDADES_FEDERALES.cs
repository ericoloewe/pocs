namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_UNIDADES_FEDERALES")]
    public partial class DIM_UNIDADES_FEDERALES
    {
        [Key]
        [StringLength(2)]
        public string ID_ESTADO { get; set; }

        [StringLength(30)]
        public string ESTADO { get; set; }

        [StringLength(30)]
        public string REGIAO { get; set; }
    }
}

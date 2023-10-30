namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_PERFILES_PRICING")]
    public partial class DIM_PERFILES_PRICING
    {
        [Key]
        public decimal ID_PERFIL { get; set; }

        [StringLength(20)]
        public string ALCADA { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        public decimal? PERFIL_AD { get; set; }

        public virtual DIM_PERFILES_AD DIM_PERFILES_AD { get; set; }
    }
}

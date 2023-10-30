namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_ESTADO_SOLICITACAO")]
    public partial class DIM_ESTADO_SOLICITACAO
    {
        [Key]
        public decimal COD_ESTADO { get; set; }

        [StringLength(150)]
        public string DESC_ESTADO { get; set; }

        public decimal? COD_GRUPO_ESTADO { get; set; }

        [StringLength(150)]
        public string DESC_GRUPO_ESTADO { get; set; }

        [StringLength(150)]
        public string DESC_ESTADO_MESA { get; set; }

        [StringLength(150)]
        public string DESCRIP_ESTADO_MESA { get; set; }
    }
}

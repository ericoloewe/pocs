namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_ALTER_TAXAS")]
    public partial class DIM_ALTER_TAXAS
    {
        [Key]
        public decimal TIPO { get; set; }

        [StringLength(200)]
        public string DESCRICAO { get; set; }
    }
}

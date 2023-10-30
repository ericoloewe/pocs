namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PARAMS_INTEGRACAO")]
    public partial class PARAMS_INTEGRACAO
    {
        [Key]
        [StringLength(100)]
        public string CHAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string VALOR { get; set; }
    }
}

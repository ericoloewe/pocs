namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PILOTO_PRECIFICACAODINAMICAUSUARIO")]
    public partial class PILOTO_PRECIFICACAODINAMICAUSUARIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(10)]
        public string LOGIN { get; set; }

        public decimal ATIVO { get; set; }
    }
}

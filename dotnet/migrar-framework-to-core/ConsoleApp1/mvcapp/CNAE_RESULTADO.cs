namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_RESULTADO")]
    public partial class CNAE_RESULTADO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CNPJ { get; set; }

        public decimal? CNAE { get; set; }

        public decimal? IDSTATUS { get; set; }

        [StringLength(400)]
        public string ERRO { get; set; }
    }
}

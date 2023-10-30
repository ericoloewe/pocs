namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_CNPJ")]
    public partial class CNAE_CNPJ
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal CNAE { get; set; }

        [Required]
        [StringLength(20)]
        public string CNPJ { get; set; }

        public DateTime DATA { get; set; }

        public bool ATIVO { get; set; }
    }
}

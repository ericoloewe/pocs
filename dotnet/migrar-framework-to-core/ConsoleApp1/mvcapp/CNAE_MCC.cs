namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_MCC")]
    public partial class CNAE_MCC
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal CNAE { get; set; }

        public decimal MCC { get; set; }

        [Required]
        public string DESCRICAO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_REJEITADAS")]
    public partial class TAXAS_PREAPROVADAS_REJEITADAS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal UPLOADID { get; set; }

        [Required]
        [StringLength(50)]
        public string CNPJ { get; set; }

        public DateTime DATA { get; set; }

        public decimal NIVELID { get; set; }

        [Required]
        [StringLength(200)]
        public string CAUSA { get; set; }

        public virtual TAXAS_PREAPROVADAS_NIVEL TAXAS_PREAPROVADAS_NIVEL { get; set; }

        public virtual TAXAS_PREAPROVADAS_UPLOAD TAXAS_PREAPROVADAS_UPLOAD { get; set; }
    }
}

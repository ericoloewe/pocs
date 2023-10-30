namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_AUDITORIA")]
    public partial class CNAE_AUDITORIA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_SOLICITACAO { get; set; }

        [Required]
        [StringLength(20)]
        public string CNPJ { get; set; }

        public DateTime DATA { get; set; }

        public decimal? IDSTATUS { get; set; }

        public virtual CNAE_STATUS CNAE_STATUS { get; set; }
    }
}

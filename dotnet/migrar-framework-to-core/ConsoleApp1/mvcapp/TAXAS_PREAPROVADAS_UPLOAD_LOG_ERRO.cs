namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO")]
    public partial class TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CNPJ { get; set; }

        public DateTime DATA { get; set; }

        [Required]
        public string DESCRICAO_ERRO { get; set; }

        public decimal ID_TAXAS_PREAPROVADAS_UPLOAD { get; set; }

        public virtual TAXAS_PREAPROVADAS_UPLOAD TAXAS_PREAPROVADAS_UPLOAD { get; set; }
    }
}

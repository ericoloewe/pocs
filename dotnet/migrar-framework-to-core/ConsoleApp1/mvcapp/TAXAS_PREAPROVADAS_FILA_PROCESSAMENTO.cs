namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO")]
    public partial class TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(500)]
        public string CAMINHO_ARQUIVO { get; set; }

        public DateTime DATA_UPLOAD { get; set; }

        public decimal PROCESSANDO { get; set; }

        public decimal NUMERO_TENTATIVAS { get; set; }

        public decimal ID_TAXAS_PREAPROVADAS_UPLOAD { get; set; }

        public virtual TAXAS_PREAPROVADAS_UPLOAD TAXAS_PREAPROVADAS_UPLOAD { get; set; }
    }
}

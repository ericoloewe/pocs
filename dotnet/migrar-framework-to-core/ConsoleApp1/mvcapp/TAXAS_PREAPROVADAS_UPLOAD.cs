namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_UPLOAD")]
    public partial class TAXAS_PREAPROVADAS_UPLOAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAXAS_PREAPROVADAS_UPLOAD()
        {
            TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO = new HashSet<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>();
            TAXAS_PREAPROVADAS_REJEITADAS = new HashSet<TAXAS_PREAPROVADAS_REJEITADAS>();
            TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO = new HashSet<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public DateTime DATA { get; set; }

        [Required]
        [StringLength(200)]
        public string USUARIOSOL { get; set; }

        [Required]
        [StringLength(200)]
        public string ARQUIVO { get; set; }

        [Required]
        [StringLength(200)]
        public string TIPOUPLOAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO> TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAXAS_PREAPROVADAS_REJEITADAS> TAXAS_PREAPROVADAS_REJEITADAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO> TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO { get; set; }
    }
}

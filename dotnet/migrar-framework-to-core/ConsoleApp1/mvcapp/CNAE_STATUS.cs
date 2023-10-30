namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_STATUS")]
    public partial class CNAE_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNAE_STATUS()
        {
            CNAE_AUDITORIA = new HashSet<CNAE_AUDITORIA>();
            SOLICITACOES_CABECALHO = new HashSet<SOLICITACOES_CABECALHO>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal CODSTATUS { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCSTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNAE_AUDITORIA> CNAE_AUDITORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITACOES_CABECALHO> SOLICITACOES_CABECALHO { get; set; }
    }
}

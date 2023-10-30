namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_NIVEL")]
    public partial class TAXAS_PREAPROVADAS_NIVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAXAS_PREAPROVADAS_NIVEL()
        {
            TAXAS_PREAPROVADAS_REJEITADAS = new HashSet<TAXAS_PREAPROVADAS_REJEITADAS>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(15)]
        public string NIVEL { get; set; }

        public decimal ATIVO { get; set; }

        public decimal PRIORIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAXAS_PREAPROVADAS_REJEITADAS> TAXAS_PREAPROVADAS_REJEITADAS { get; set; }
    }
}

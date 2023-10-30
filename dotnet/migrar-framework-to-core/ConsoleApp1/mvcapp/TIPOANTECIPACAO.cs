namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TIPOANTECIPACAO")]
    public partial class TIPOANTECIPACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOANTECIPACAO()
        {
            ANTECIPACAOSEGM = new HashSet<ANTECIPACAOSEGM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        public decimal ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANTECIPACAOSEGM> ANTECIPACAOSEGM { get; set; }
    }
}

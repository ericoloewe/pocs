namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_SEGMENTOS")]
    public partial class DIM_SEGMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_SEGMENTOS()
        {
            ANTECIPACAOSEGM = new HashSet<ANTECIPACAOSEGM>();
            SEGMENTO_TERMO = new HashSet<SEGMENTO_TERMO>();
        }

        [Key]
        public decimal ID_SEGMENTO { get; set; }

        [StringLength(100)]
        public string COD_SEGMENTO { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [StringLength(100)]
        public string DESC_SEGMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANTECIPACAOSEGM> ANTECIPACAOSEGM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEGMENTO_TERMO> SEGMENTO_TERMO { get; set; }
    }
}

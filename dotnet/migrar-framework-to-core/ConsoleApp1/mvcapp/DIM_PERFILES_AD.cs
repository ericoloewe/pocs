namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_PERFILES_AD")]
    public partial class DIM_PERFILES_AD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_PERFILES_AD()
        {
            DIM_PERFILES_PRICING = new HashSet<DIM_PERFILES_PRICING>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(20)]
        public string PERFIL { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIM_PERFILES_PRICING> DIM_PERFILES_PRICING { get; set; }
    }
}

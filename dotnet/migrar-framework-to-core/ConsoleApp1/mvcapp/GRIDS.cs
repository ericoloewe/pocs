namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.GRIDS")]
    public partial class GRIDS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRIDS()
        {
            GRIDS_DIMENSION_COLUMNS = new HashSet<GRIDS_DIMENSION_COLUMNS>();
            GRIDS_DIMENSION_ROWS = new HashSet<GRIDS_DIMENSION_ROWS>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRIDS_DIMENSION_COLUMNS> GRIDS_DIMENSION_COLUMNS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRIDS_DIMENSION_ROWS> GRIDS_DIMENSION_ROWS { get; set; }
    }
}

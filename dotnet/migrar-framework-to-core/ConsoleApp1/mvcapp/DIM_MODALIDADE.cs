namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_MODALIDADE")]
    public partial class DIM_MODALIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_MODALIDADE()
        {
            GRIDS_DIMENSION_COLUMNS = new HashSet<GRIDS_DIMENSION_COLUMNS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_MODALIDADE { get; set; }

        [StringLength(100)]
        public string DESC_MODALIDADE { get; set; }

        [StringLength(100)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string HEADER { get; set; }

        public int? ORDENACAO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRIDS_DIMENSION_COLUMNS> GRIDS_DIMENSION_COLUMNS { get; set; }
    }
}

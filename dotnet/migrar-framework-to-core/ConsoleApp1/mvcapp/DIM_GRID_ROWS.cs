namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_GRID_ROWS")]
    public partial class DIM_GRID_ROWS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_GRID_ROWS()
        {
            GRIDS_DIMENSION_ROWS = new HashSet<GRIDS_DIMENSION_ROWS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal COD_ROW { get; set; }

        [StringLength(100)]
        public string TAXA_NAME { get; set; }

        [StringLength(300)]
        public string TITULO { get; set; }

        public decimal? TIPO { get; set; }

        public bool? ATIVO { get; set; }

        [Required]
        [StringLength(3)]
        public string COD_TIPO_TAXA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRIDS_DIMENSION_ROWS> GRIDS_DIMENSION_ROWS { get; set; }
    }
}

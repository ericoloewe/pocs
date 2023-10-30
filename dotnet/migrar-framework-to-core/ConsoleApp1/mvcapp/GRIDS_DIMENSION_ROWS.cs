namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.GRIDS_DIMENSION_ROWS")]
    public partial class GRIDS_DIMENSION_ROWS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_GRIDS { get; set; }

        public decimal COD_ROW { get; set; }

        public virtual DIM_GRID_ROWS DIM_GRID_ROWS { get; set; }

        public virtual GRIDS GRIDS { get; set; }
    }
}

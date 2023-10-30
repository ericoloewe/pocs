namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.GRIDS_DIMENSION_COLUMNS")]
    public partial class GRIDS_DIMENSION_COLUMNS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_GRIDS { get; set; }

        public decimal COD_COLUMN { get; set; }

        public virtual DIM_MODALIDADE DIM_MODALIDADE { get; set; }

        public virtual GRIDS GRIDS { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_RAMOS")]
    public partial class DIM_RAMOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_RAMO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_RAMO { get; set; }
    }
}

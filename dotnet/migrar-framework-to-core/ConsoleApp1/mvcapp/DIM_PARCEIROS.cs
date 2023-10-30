namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_PARCEIROS")]
    public partial class DIM_PARCEIROS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_PARCEIRO { get; set; }

        public decimal ID_SEGMENTO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_PARCEIRO { get; set; }

        [Required]
        [StringLength(18)]
        public string CNPJ { get; set; }

        [StringLength(7)]
        public string REGIONAL { get; set; }

        [StringLength(7)]
        public string AGENCIA { get; set; }
    }
}

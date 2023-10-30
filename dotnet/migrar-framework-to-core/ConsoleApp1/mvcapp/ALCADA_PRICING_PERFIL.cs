namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_PRICING_PERFIL")]
    public partial class ALCADA_PRICING_PERFIL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PERFIL { get; set; }

        [Required]
        [StringLength(100)]
        public string SEGMENTO { get; set; }

        public decimal MARGEM_COM_EVIDENCIA { get; set; }

        public decimal MARGEM_SEM_EVIDENCIA { get; set; }

        public DateTime DATA_INSERT { get; set; }
    }
}

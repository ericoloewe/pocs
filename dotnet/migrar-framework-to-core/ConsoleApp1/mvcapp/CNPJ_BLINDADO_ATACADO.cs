namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNPJ_BLINDADO_ATACADO")]
    public partial class CNPJ_BLINDADO_ATACADO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string SEGMENTO { get; set; }

        public DateTime DATA_INCLUSAO { get; set; }

        public DateTime DATA_VALIDADE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}

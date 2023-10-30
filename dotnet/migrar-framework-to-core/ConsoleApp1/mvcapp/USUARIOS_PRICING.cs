namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.USUARIOS_PRICING")]
    public partial class USUARIOS_PRICING
    {
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(20)]
        public string LOGIN { get; set; }

        public decimal? MATRICULA { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string EMAIL { get; set; }

        public decimal ATIVO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_INSERT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal? RELATORIOS { get; set; }
    }
}

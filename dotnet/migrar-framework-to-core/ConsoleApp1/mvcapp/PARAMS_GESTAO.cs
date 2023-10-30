namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PARAMS_GESTAO")]
    public partial class PARAMS_GESTAO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_TIPO { get; set; }

        [StringLength(200)]
        public string NOME { get; set; }

        [StringLength(200)]
        public string VALUE { get; set; }

        [StringLength(2000)]
        public string DESCRICAO { get; set; }

        public decimal? ATIVO { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }
    }
}

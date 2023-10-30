namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.FILAGERENCIAL")]
    public partial class FILAGERENCIAL
    {
        [Required]
        [StringLength(45)]
        public string TIPODEENVIO { get; set; }

        public decimal? IDSOLICITACAO { get; set; }

        [StringLength(500)]
        public string CNPJ { get; set; }

        public bool? PROCESSANDO { get; set; }

        public decimal? NUMEROTENTATIVAS { get; set; }

        public DateTime DATA { get; set; }

        public decimal? IDREPRECIFICACAO { get; set; }

        public decimal ID { get; set; }

        public DateTime? DATAENVIOGERENCIAL { get; set; }

        [StringLength(50)]
        public string LOGIN { get; set; }
    }
}

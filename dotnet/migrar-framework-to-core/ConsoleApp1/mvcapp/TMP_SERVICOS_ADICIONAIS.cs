namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_SERVICOS_ADICIONAIS")]
    public partial class TMP_SERVICOS_ADICIONAIS
    {
        [Key]
        [Column(Order = 0)]
        public DateTime DATA_INSERT { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_TIPO_SERVICO { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal COD_SERVICO { get; set; }

        [StringLength(200)]
        public string NOME_SERVICO { get; set; }

        [StringLength(200)]
        public string DESCRICAO { get; set; }

        public decimal? VALUE { get; set; }

        public decimal? VOLUME { get; set; }

        public decimal? ATIVO { get; set; }

        public DateTime? DATA_ALTERACAO { get; set; }
    }
}

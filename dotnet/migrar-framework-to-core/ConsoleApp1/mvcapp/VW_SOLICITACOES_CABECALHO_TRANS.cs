namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.VW_SOLICITACOES_CABECALHO_TRANS")]
    public partial class VW_SOLICITACOES_CABECALHO_TRANS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_SOLICITACAO { get; set; }

        [StringLength(20)]
        public string CNPJ { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_ESTADO { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATA_SOLICITACAO { get; set; }

        public DateTime? DATA_ENVIO_GERENCIAL { get; set; }

        public decimal? ULTIMA_ORDEM { get; set; }

        public DateTime? ULTIMA_ALTERACAO { get; set; }

        [StringLength(100)]
        public string ULTIMO_LOGIN { get; set; }

        [StringLength(100)]
        public string PRIMEIRO_LOGIN { get; set; }

        [StringLength(100)]
        public string PRIMEIRA_AREA { get; set; }

        public decimal? ID_TAXA { get; set; }

        public decimal? IDSTATUS { get; set; }

        public decimal? ID_PARCEIRO { get; set; }

        public decimal? TIPO_SOLICITACAO { get; set; }

        public decimal? ID_SIMULACAO_EFETIVADA { get; set; }

        public decimal? TERMO_ATIVO { get; set; }

        public decimal? ID_COMBO_PROM { get; set; }

        public decimal? ID_CNPJ_TAXAS_PREAPROVADAS { get; set; }

        public DateTime? DT_TERMO_INI { get; set; }

        public DateTime? DT_TERMO_FINAL { get; set; }

        public decimal? ID_SEGMENTO { get; set; }

        [StringLength(100)]
        public string DESC_PARCEIRO { get; set; }
    }
}

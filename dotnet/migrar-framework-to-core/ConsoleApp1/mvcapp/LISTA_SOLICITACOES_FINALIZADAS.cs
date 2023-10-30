namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.LISTA_SOLICITACOES_FINALIZADAS")]
    public partial class LISTA_SOLICITACOES_FINALIZADAS
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        public decimal ID_SOLICITACAO { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        [StringLength(100)]
        public string PERFIL { get; set; }

        [StringLength(100)]
        public string AREA { get; set; }

        [StringLength(100)]
        public string LOGIN { get; set; }

        [StringLength(20)]
        public string CNPJ { get; set; }

        [StringLength(400)]
        public string RAZAO_SOCIAL { get; set; }

        [StringLength(100)]
        public string REGIONAL { get; set; }

        [StringLength(100)]
        public string REGIONAL_ALTERADA { get; set; }

        public decimal? FATURAMENTO_GETNET { get; set; }

        [StringLength(400)]
        public string ESTADO_PORTAL { get; set; }

        [StringLength(400)]
        public string ESTADO_MESA { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        public string LISTA_CNPJ { get; set; }
    }
}

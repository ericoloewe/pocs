namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_GRUPO")]
    public partial class HIST_SOLICITACOES_GRUPO
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CNPJ_MASTER { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CNPJ_GRUPO { get; set; }

        public decimal? ADICIONAL { get; set; }
    }
}

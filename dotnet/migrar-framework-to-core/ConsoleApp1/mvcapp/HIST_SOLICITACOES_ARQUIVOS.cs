namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_ARQUIVOS")]
    public partial class HIST_SOLICITACOES_ARQUIVOS
    {
        public DateTime? DATA_UPLOAD { get; set; }

        [Key]
        public decimal ID_SOLICITACAO { get; set; }

        [StringLength(1000)]
        public string ARQUIVO { get; set; }

        [StringLength(3)]
        public string TIPO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNAE_LISTA_PROC")]
    public partial class CNAE_LISTA_PROC
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_SOLICITACAO { get; set; }

        public DateTime DATASOLIC { get; set; }

        public decimal NUMTENTATIVAS { get; set; }

        public bool PROCESSANDO { get; set; }
    }
}

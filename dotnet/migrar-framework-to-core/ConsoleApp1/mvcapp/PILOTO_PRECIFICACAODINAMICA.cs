namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PILOTO_PRECIFICACAODINAMICA")]
    public partial class PILOTO_PRECIFICACAODINAMICA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(10)]
        public string UNIORG_REGIONAL { get; set; }

        [StringLength(10)]
        public string UNIORG_AGENCIA { get; set; }

        public decimal ATIVO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIERARQUIA_COMERCIAIS_GETNET")]
    public partial class HIERARQUIA_COMERCIAIS_GETNET
    {
        public DateTime? DATA_INSERT { get; set; }

        public decimal? ATIVO { get; set; }

        [StringLength(100)]
        public string EMPRESA { get; set; }

        [StringLength(15)]
        public string MATRICULA { get; set; }

        [StringLength(500)]
        public string NOME { get; set; }

        [StringLength(100)]
        public string USUARIO { get; set; }

        [StringLength(500)]
        public string CARGO { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [StringLength(500)]
        public string SEGMENTO_RH { get; set; }

        [StringLength(500)]
        public string EMAIL { get; set; }

        [StringLength(10)]
        public string COD_REDE { get; set; }

        [StringLength(500)]
        public string REDE { get; set; }

        [StringLength(10)]
        public string UNIORG_REGIONAL { get; set; }

        [StringLength(500)]
        public string REGIONAL { get; set; }

        [StringLength(10)]
        public string COD_NUCLEO { get; set; }

        [StringLength(500)]
        public string NUCLEO { get; set; }

        [StringLength(5)]
        public string UF { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }
    }
}

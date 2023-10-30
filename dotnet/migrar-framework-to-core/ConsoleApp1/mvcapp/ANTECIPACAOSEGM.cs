namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ANTECIPACAOSEGM")]
    public partial class ANTECIPACAOSEGM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal SEGMENTOID { get; set; }

        public bool TEMANTECIPACAO { get; set; }

        public decimal TIPOANTECIPACAOID { get; set; }

        public decimal TAXAANTECIPACAOID { get; set; }

        public bool ATIVA { get; set; }

        [StringLength(10)]
        public string IDSTIPOANTECIPACAO { get; set; }

        public virtual DIM_SEGMENTOS DIM_SEGMENTOS { get; set; }

        public virtual TAXAANTECIPACAO TAXAANTECIPACAO { get; set; }

        public virtual TIPOANTECIPACAO TIPOANTECIPACAO { get; set; }
    }
}

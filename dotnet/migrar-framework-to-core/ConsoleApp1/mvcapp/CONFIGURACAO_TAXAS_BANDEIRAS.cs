namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CONFIGURACAO_TAXAS_BANDEIRAS")]
    public partial class CONFIGURACAO_TAXAS_BANDEIRAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_CONFIGURACAO { get; set; }

        public decimal ID_BANDEIRA { get; set; }

        public bool DEBITO_A_VISTA { get; set; }

        public bool CARNE { get; set; }

        public bool RECORRENTE { get; set; }

        public bool CREDIARIO { get; set; }

        public virtual DIM_BANDEIRAS DIM_BANDEIRAS { get; set; }
    }
}

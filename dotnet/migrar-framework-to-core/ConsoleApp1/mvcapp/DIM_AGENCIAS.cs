namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_AGENCIAS")]
    public partial class DIM_AGENCIAS
    {
        [Key]
        [StringLength(10)]
        public string UNIORG_AGENCIA { get; set; }

        [StringLength(300)]
        public string NOME_AGENCIA { get; set; }

        [StringLength(200)]
        public string RED { get; set; }

        [StringLength(10)]
        public string UNIORG_REGIONAL { get; set; }

        [StringLength(200)]
        public string REGIONAL { get; set; }

        [StringLength(10)]
        public string COD_REDE { get; set; }
    }
}

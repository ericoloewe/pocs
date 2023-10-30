namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TAXAS_PREAPROVADAS_UPLOAD_STATUS")]
    public partial class TAXAS_PREAPROVADAS_UPLOAD_STATUS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}

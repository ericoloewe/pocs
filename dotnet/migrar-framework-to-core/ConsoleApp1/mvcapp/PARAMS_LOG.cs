namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PARAMS_LOG")]
    public partial class PARAMS_LOG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(200)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(30)]
        public string ACTION { get; set; }

        [Required]
        [StringLength(100)]
        public string TABELA { get; set; }

        public string INFO { get; set; }

        public DateTime DATA_INSERT { get; set; }
    }
}

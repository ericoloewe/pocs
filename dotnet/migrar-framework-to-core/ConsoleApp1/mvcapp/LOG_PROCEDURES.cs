namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.LOG_PROCEDURES")]
    public partial class LOG_PROCEDURES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_LOG_PROCEDURES { get; set; }

        public DateTime? DATA { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        public string PARAMETROS { get; set; }
    }
}

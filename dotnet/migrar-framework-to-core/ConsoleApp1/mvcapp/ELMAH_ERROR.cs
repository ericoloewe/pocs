namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ELMAH_ERROR")]
    public partial class ELMAH_ERROR
    {
        [Key]
        public Guid ERRORID { get; set; }

        [Required]
        [StringLength(60)]
        public string APPLICATION { get; set; }

        [Required]
        [StringLength(50)]
        public string HOST { get; set; }

        [Required]
        [StringLength(100)]
        public string TYPE { get; set; }

        [Required]
        [StringLength(60)]
        public string SOURCE { get; set; }

        [Required]
        [StringLength(500)]
        public string MESSAGE { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public decimal STATUSCODE { get; set; }

        public DateTime TIMEUTC { get; set; }

        public decimal SEQUENCE { get; set; }

        [Required]
        public string ALLXML { get; set; }
    }
}

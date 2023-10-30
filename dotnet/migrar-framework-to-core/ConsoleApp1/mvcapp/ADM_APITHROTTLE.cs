namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ADM_APITHROTTLE")]
    public partial class ADM_APITHROTTLE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ENDPOINT { get; set; }

        public int RATELIMITPERIOD { get; set; }

        public int RATELIMIT { get; set; }

        public bool ENABLED { get; set; }
    }
}

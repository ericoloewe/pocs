namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.AUMENTO_TAXAS")]
    public partial class AUMENTO_TAXAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_SEGMENTO { get; set; }

        [StringLength(50)]
        public string SEGMENTO { get; set; }

        public short? NUM_MESES_CARENCIA { get; set; }

        public decimal? PCT_FAT_REAL { get; set; }

        public decimal? AUMENTO_TAXA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_INSERT { get; set; }
    }
}

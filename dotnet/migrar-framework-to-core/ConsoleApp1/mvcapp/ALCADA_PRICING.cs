namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ALCADA_PRICING")]
    public partial class ALCADA_PRICING
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_PERFIL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ALCADA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string PERFIL { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_SEGMENTO { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        public decimal? MOL_SE { get; set; }

        public decimal? BAI_SE { get; set; }

        public decimal? MDR_L_SE { get; set; }

        public decimal? MOL_CE { get; set; }

        public decimal? BAI_CE { get; set; }

        public decimal? MDR_L_CE { get; set; }

        public decimal? MAX_DESC_ALU { get; set; }

        public decimal ID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DATA_INSERT { get; set; }
    }
}

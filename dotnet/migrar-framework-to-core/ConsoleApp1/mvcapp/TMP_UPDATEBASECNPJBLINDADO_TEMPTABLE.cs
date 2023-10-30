namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE")]
    public partial class TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE
    {
        public decimal? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CNPJ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATA_INCLUSAO { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATA_VALIDADE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}

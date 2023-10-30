namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.LOG_SERVICE_ANTECIPACAO")]
    public partial class LOG_SERVICE_ANTECIPACAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_LOG_SERVICE_ANTECIPACAO { get; set; }

        public DateTime DATA_LOG { get; set; }

        [StringLength(20)]
        public string EC { get; set; }

        [StringLength(250)]
        public string ACAO { get; set; }

        [StringLength(40)]
        public string ETAPA { get; set; }

        public decimal? SUCESSO { get; set; }

        [Required]
        public string DETALHES { get; set; }

        [StringLength(50)]
        public string LOGIN { get; set; }

        [StringLength(50)]
        public string PERFIL { get; set; }

        [StringLength(100)]
        public string IP { get; set; }
    }
}

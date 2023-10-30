namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.LOG")]
    public partial class LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_LOG { get; set; }

        public DateTime DATA { get; set; }

        [Required]
        [StringLength(10)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(200)]
        public string ORIGEM { get; set; }

        [Required]
        public string MENSAGEM { get; set; }

        [StringLength(50)]
        public string LOGIN { get; set; }

        [StringLength(50)]
        public string PERFIL { get; set; }

        [StringLength(100)]
        public string IP { get; set; }

        [StringLength(20)]
        public string CNPJ { get; set; }

        public decimal? ID_SOLICITACAO { get; set; }
    }
}

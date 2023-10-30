namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ANALYTICS_CABECALHO")]
    public partial class ANALYTICS_CABECALHO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_ANALYTICS_CABECALHO { get; set; }

        [Required]
        [StringLength(40)]
        public string USUARIO { get; set; }

        [StringLength(200)]
        public string NOME { get; set; }

        public DateTime DATA_ACESSO { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        [StringLength(30)]
        public string SO { get; set; }

        [StringLength(30)]
        public string IDIOMA { get; set; }

        [StringLength(30)]
        public string BROWSER { get; set; }

        public bool? MOBILE { get; set; }

        public bool? COOKIES { get; set; }

        [StringLength(30)]
        public string TAMANHO_TELA { get; set; }

        [StringLength(30)]
        public string TAMANHO_JANELA { get; set; }

        [StringLength(30)]
        public string VERSAO { get; set; }
    }
}

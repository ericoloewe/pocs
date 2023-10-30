namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_USUARIOS_PRICING_ACESSOS")]
    public partial class DIM_USUARIOS_PRICING_ACESSOS
    {
        public decimal ID { get; set; }

        [StringLength(200)]
        public string NOME { get; set; }

        [Required]
        [StringLength(10)]
        public string LOGIN { get; set; }

        public bool? ATIVO { get; set; }

        public bool? RELATORIOS { get; set; }

        public bool? TRACKING { get; set; }

        public bool? SLA { get; set; }

        public bool? TEMPO_PROMEDIO { get; set; }

        public bool? SOLICITACOES_APROVADAS { get; set; }

        public bool? SEGUIMENTO_USUARIOS { get; set; }

        public bool? SEGUIMENTO_HORAS { get; set; }

        public bool? SIMULADOR_PARAMS { get; set; }

        public DateTime? DATA_INSERT { get; set; }

        public DateTime? DATA_UPDATE { get; set; }
    }
}

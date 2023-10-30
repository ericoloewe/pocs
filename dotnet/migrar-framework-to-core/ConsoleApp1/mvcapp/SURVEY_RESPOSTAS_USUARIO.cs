namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SURVEY_RESPOSTAS_USUARIO")]
    public partial class SURVEY_RESPOSTAS_USUARIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_CABECALHO { get; set; }

        public decimal ID_QUESTAO { get; set; }

        public decimal ID_RESPOSTA { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGIN { get; set; }

        public virtual SURVEY_CABECALHO SURVEY_CABECALHO { get; set; }

        public virtual SURVEY_QUESTOES SURVEY_QUESTOES { get; set; }

        public virtual SURVEY_RESPOSTAS SURVEY_RESPOSTAS { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SURVEY_CABECALHO")]
    public partial class SURVEY_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SURVEY_CABECALHO()
        {
            SURVEY_CONTROLE_VISUALIZACAO = new HashSet<SURVEY_CONTROLE_VISUALIZACAO>();
            SURVEY_QUESTOES = new HashSet<SURVEY_QUESTOES>();
            SURVEY_RESPOSTAS_USUARIO = new HashSet<SURVEY_RESPOSTAS_USUARIO>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal TIPO { get; set; }

        public DateTime DATA { get; set; }

        [StringLength(100)]
        public string GMUD { get; set; }

        [StringLength(100)]
        public string TASK_JIRA { get; set; }

        public decimal? TIPO_TASK { get; set; }

        public DateTime? DT_INICIO_VIGENCIA { get; set; }

        [Required]
        [StringLength(100)]
        public string TITULO { get; set; }

        public string DESCRICAO { get; set; }

        public byte[] IMAGEM { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_CONTROLE_VISUALIZACAO> SURVEY_CONTROLE_VISUALIZACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_QUESTOES> SURVEY_QUESTOES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_RESPOSTAS_USUARIO> SURVEY_RESPOSTAS_USUARIO { get; set; }
    }
}

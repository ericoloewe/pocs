namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SURVEY_QUESTOES")]
    public partial class SURVEY_QUESTOES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SURVEY_QUESTOES()
        {
            SURVEY_RESPOSTAS = new HashSet<SURVEY_RESPOSTAS>();
            SURVEY_RESPOSTAS_USUARIO = new HashSet<SURVEY_RESPOSTAS_USUARIO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_QUESTAO { get; set; }

        public decimal ID_CABECALHO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRICAO { get; set; }

        public virtual SURVEY_CABECALHO SURVEY_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_RESPOSTAS> SURVEY_RESPOSTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_RESPOSTAS_USUARIO> SURVEY_RESPOSTAS_USUARIO { get; set; }
    }
}

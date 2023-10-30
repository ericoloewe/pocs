namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SURVEY_RESPOSTAS")]
    public partial class SURVEY_RESPOSTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SURVEY_RESPOSTAS()
        {
            SURVEY_RESPOSTAS_USUARIO = new HashSet<SURVEY_RESPOSTAS_USUARIO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_RESPOSTA { get; set; }

        public decimal ID_QUESTAO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRICAO { get; set; }

        public virtual SURVEY_QUESTOES SURVEY_QUESTOES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SURVEY_RESPOSTAS_USUARIO> SURVEY_RESPOSTAS_USUARIO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SURVEY_CONTROLE_VISUALIZACAO")]
    public partial class SURVEY_CONTROLE_VISUALIZACAO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal ID_CABECALHO { get; set; }

        [Required]
        [StringLength(50)]
        public string REGIONAL { get; set; }

        public virtual SURVEY_CABECALHO SURVEY_CABECALHO { get; set; }
    }
}

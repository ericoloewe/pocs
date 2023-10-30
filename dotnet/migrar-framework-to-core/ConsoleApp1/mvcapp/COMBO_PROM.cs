namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.COMBO_PROM")]
    public partial class COMBO_PROM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMBO_PROM()
        {
            ALCADA = new HashSet<ALCADA>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TITULO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRICAO { get; set; }

        [StringLength(100)]
        public string FRASE_PROM_CABECALHO { get; set; }

        [StringLength(100)]
        public string FRASE_PROM_RODAPE { get; set; }

        public string REGULAMENTO { get; set; }

        [StringLength(200)]
        public string COD_CAMPANHA { get; set; }

        [StringLength(200)]
        public string COD_OFERTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALCADA> ALCADA { get; set; }
    }
}

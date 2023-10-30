namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.DIM_BANDEIRAS")]
    public partial class DIM_BANDEIRAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_BANDEIRAS()
        {
            CONFIGURACAO_TAXAS_BANDEIRAS = new HashSet<CONFIGURACAO_TAXAS_BANDEIRAS>();
        }

        [Key]
        public decimal COD_BANDEIRA { get; set; }

        [StringLength(150)]
        public string DESC_BANDEIRA { get; set; }

        public short? ATIVO { get; set; }

        [StringLength(230)]
        public string IMAGEM { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURACAO_TAXAS_BANDEIRAS> CONFIGURACAO_TAXAS_BANDEIRAS { get; set; }
    }
}

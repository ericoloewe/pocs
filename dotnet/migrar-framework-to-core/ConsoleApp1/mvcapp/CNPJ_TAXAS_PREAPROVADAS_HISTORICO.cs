namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.CNPJ_TAXAS_PREAPROVADAS_HISTORICO")]
    public partial class CNPJ_TAXAS_PREAPROVADAS_HISTORICO
    {
        public DateTime? DATA_INSERT { get; set; }

        public DateTime? DATA_INICIO { get; set; }

        public DateTime? DATA_FIN { get; set; }

        [StringLength(50)]
        public string CNPJ { get; set; }

        public decimal? FAT_CRED { get; set; }

        public decimal? FAT_PARC { get; set; }

        public decimal? FAT_DEB { get; set; }

        public decimal? TAXA_PREAP_CRED_VISA { get; set; }

        public decimal? TAXA_PREAP_DEB_VISA { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_VISA { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_VISA { get; set; }

        public decimal? TAXA_PREAP_CARNE_VISA { get; set; }

        public decimal? TAXA_PREAP_RECO_VISA { get; set; }

        public decimal? TAXA_PREAP_CRED_MC { get; set; }

        public decimal? TAXA_PREAP_DEB_MC { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_MC { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_MC { get; set; }

        public decimal? TAXA_PREAP_CARNE_MC { get; set; }

        public decimal? TAXA_PREAP_RECO_MC { get; set; }

        public decimal? TAXA_PREAP_CRED_ELO { get; set; }

        public decimal? TAXA_PREAP_DEB_ELO { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_ELO { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_ELO { get; set; }

        public decimal? TAXA_PREAP_CARNE_ELO { get; set; }

        public decimal? TAXA_PREAP_RECO_ELO { get; set; }

        public decimal? TAXA_PREAP_CRED_AMEX { get; set; }

        public decimal? TAXA_PREAP_DEB_AMEX { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_AMEX { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_AMEX { get; set; }

        public decimal? TAXA_PREAP_CARNE_AMEX { get; set; }

        public decimal? TAXA_PREAP_RECO_AMEX { get; set; }

        public decimal? TAXA_PREAP_CRED_HIPER { get; set; }

        public decimal? TAXA_PREAP_DEB_HIPER { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_HIPER { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_HIPER { get; set; }

        public decimal? TAXA_PREAP_CARNE_HIPER { get; set; }

        public decimal? TAXA_PREAP_RECO_HIPER { get; set; }

        public decimal? TAXA_PREAP_CRED_HIPERCARD { get; set; }

        public decimal? TAXA_PREAP_DEB_HIPERCARD { get; set; }

        public decimal? TAXA_PREAP_PARC_2_6_HIPERCARD { get; set; }

        public decimal? TAXA_PREAP_PARC_7_12_HIPERCARD { get; set; }

        public decimal? TAXA_PREAP_CARNE_HIPERCARD { get; set; }

        public decimal? TAXA_PREAP_RECO_HIPERCARD { get; set; }

        public decimal? MULTA { get; set; }

        public decimal? SUBSIDIO { get; set; }

        public int? PRAZO_LIQ { get; set; }

        public DateTime? VIGENCIA { get; set; }

        [StringLength(200)]
        public string CODIGO_CONTROLE { get; set; }

        public decimal? TAXA_PREAP_CREDIARIO_VISA { get; set; }

        public decimal? TAXA_PREAP_CREDIARIO_MC { get; set; }

        public decimal? TAXA_PREAP_CREDIARIO_ELO { get; set; }

        public decimal? TAXA_PREAP_CREDIARIO_AMEX { get; set; }

        public decimal? TAXA_PREAP_CREDIARIO_HIPER { get; set; }

        public int NIVELID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_CNPJ_TAXAS_PREAPROVADAS { get; set; }

        [StringLength(1)]
        public string ANTECIPACAO { get; set; }

        public decimal? ANTEC_AUTO_PERC { get; set; }

        [StringLength(1)]
        public string ANTEC_PONTUAL { get; set; }

        public decimal? ANTEC_PONTUAL_PERC { get; set; }
    }
}

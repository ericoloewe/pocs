namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.REPRECIFICACAO")]
    public partial class REPRECIFICACAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_REPRECIFICACAO { get; set; }

        [StringLength(20)]
        public string CNPJ { get; set; }

        public decimal ECOMM { get; set; }

        public DateTime DATA_IMPORTACAO { get; set; }

        public decimal? VISA_CREDITO_A_VISTA { get; set; }

        public decimal? VISA_DEBITO { get; set; }

        public decimal? VISA_PARC_2_6 { get; set; }

        public decimal? VISA_PARC_7_12 { get; set; }

        public decimal? VISA_CARNE { get; set; }

        public decimal? VISA_RECORRENTE { get; set; }

        public decimal? MASTER_CREDITO_A_VISTA { get; set; }

        public decimal? MASTER_DEBITO { get; set; }

        public decimal? MASTER_PARC_2_6 { get; set; }

        public decimal? MASTER_PARC_7_12 { get; set; }

        public decimal? MASTER_CARNE { get; set; }

        public decimal? MASTER_RECORRENTE { get; set; }

        public decimal? ELO_CREDITO_A_VISTA { get; set; }

        public decimal? ELO_DEBITO { get; set; }

        public decimal? ELO_PARC_2_6 { get; set; }

        public decimal? ELO_CARNE { get; set; }

        public decimal? ELO_RECORRENTE { get; set; }

        public decimal? AMEX_CREDITO_A_VISTA { get; set; }

        public decimal? AMEX_DEBITO { get; set; }

        public decimal? AMEX_PARC_2_6 { get; set; }

        public decimal? AMEX_CARNE { get; set; }

        public decimal? AMEX_RECORRENTE { get; set; }

        public decimal? HIPER_CREDITO_A_VISTA { get; set; }

        public decimal? HIPER_DEBITO { get; set; }

        public decimal? HIPER_PARC_2_6 { get; set; }

        public decimal? HIPER_CARNE { get; set; }

        public decimal? HIPER_RECORRENTE { get; set; }

        public DateTime? DATA_VIG_INI { get; set; }

        [StringLength(20)]
        public string USUARIO { get; set; }

        public decimal? ID_DIM_REPREC_EVENTO { get; set; }

        public decimal? OLD_VISA_CREDITO_A_VISTA { get; set; }

        public decimal? OLD_VISA_DEBITO { get; set; }

        public decimal? OLD_VISA_PARC_2_6 { get; set; }

        public decimal? OLD_VISA_PARC_7_12 { get; set; }

        public decimal? OLD_VISA_CARNE { get; set; }

        public decimal? OLD_VISA_RECORRENTE { get; set; }

        public decimal? OLD_MASTER_CREDITO_A_VISTA { get; set; }

        public decimal? OLD_MASTER_DEBITO { get; set; }

        public decimal? OLD_MASTER_PARC_2_6 { get; set; }

        public decimal? OLD_MASTER_PARC_7_12 { get; set; }

        public decimal? OLD_MASTER_CARNE { get; set; }

        public decimal? OLD_MASTER_RECORRENTE { get; set; }

        public decimal? OLD_ELO_CREDITO_A_VISTA { get; set; }

        public decimal? OLD_ELO_DEBITO { get; set; }

        public decimal? OLD_ELO_PARC_2_6 { get; set; }

        public decimal? OLD_ELO_PARC_7_12 { get; set; }

        public decimal? OLD_ELO_CARNE { get; set; }

        public decimal? OLD_ELO_RECORRENTE { get; set; }

        public decimal? OLD_AMEX_CREDITO_A_VISTA { get; set; }

        public decimal? OLD_AMEX_DEBITO { get; set; }

        public decimal? OLD_AMEX_PARC_2_6 { get; set; }

        public decimal? OLD_AMEX_PARC_7_12 { get; set; }

        public decimal? OLD_AMEX_CARNE { get; set; }

        public decimal? OLD_AMEX_RECORRENTE { get; set; }

        public decimal? OLD_HIPER_CREDITO_A_VISTA { get; set; }

        public decimal? OLD_HIPER_DEBITO { get; set; }

        public decimal? OLD_HIPER_PARC_2_6 { get; set; }

        public decimal? OLD_HIPER_PARC_7_12 { get; set; }

        public decimal? OLD_HIPER_CARNE { get; set; }

        public decimal? OLD_HIPER_RECORRENTE { get; set; }

        [StringLength(3000)]
        public string STATUS { get; set; }

        public DateTime? DATA_ENVIO_GERENCIAL { get; set; }

        public decimal? ELOPARC_7_12 { get; set; }

        public decimal? AMEXPARC_7_12 { get; set; }

        public decimal? HIPERPARC_7_12 { get; set; }
    }
}

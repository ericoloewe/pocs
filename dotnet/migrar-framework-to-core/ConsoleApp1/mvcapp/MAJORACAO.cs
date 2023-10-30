namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.MAJORACAO")]
    public partial class MAJORACAO
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        public DateTime? DATA_ENVIO_GERENCIAL { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_MAJORACAO { get; set; }

        [StringLength(20)]
        public string USUARIO { get; set; }

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

        public decimal? AMEX_PARC_7_12 { get; set; }

        public decimal? ELO_PARC_7_12 { get; set; }

        public decimal? HIPER_PARC_7_12 { get; set; }

        public decimal? ECOM_VISA_CREDITO_A_VISTA { get; set; }

        public decimal? ECOM_VISA_DEBITO { get; set; }

        public decimal? ECOM_VISA_PARC_2_6 { get; set; }

        public decimal? ECOM_VISA_PARC_7_12 { get; set; }

        public decimal? ECOM_VISA_CARNE { get; set; }

        public decimal? ECOM_VISA_RECORRENTE { get; set; }

        public decimal? ECOM_MASTER_CREDITO_A_VISTA { get; set; }

        public decimal? ECOM_MASTER_DEBITO { get; set; }

        public decimal? ECOM_MASTER_PARC_2_6 { get; set; }

        public decimal? ECOM_MASTER_PARC_7_12 { get; set; }

        public decimal? ECOM_MASTER_CARNE { get; set; }

        public decimal? ECOM_MASTER_RECORRENTE { get; set; }

        public decimal? ECOM_ELO_CREDITO_A_VISTA { get; set; }

        public decimal? ECOM_ELO_DEBITO { get; set; }

        public decimal? ECOM_ELO_PARC_2_6 { get; set; }

        public decimal? ECOM_ELO_PARC_7_12 { get; set; }

        public decimal? ECOM_ELO_CARNE { get; set; }

        public decimal? ECOM_ELO_RECORRENTE { get; set; }

        public decimal? ECOM_AMEX_CREDITO_A_VISTA { get; set; }

        public decimal? ECOM_AMEX_DEBITO { get; set; }

        public decimal? ECOM_AMEX_PARC_2_6 { get; set; }

        public decimal? ECOM_AMEX_PARC_7_12 { get; set; }

        public decimal? ECOM_AMEX_CARNE { get; set; }

        public decimal? ECOM_AMEX_RECORRENTE { get; set; }

        public decimal? ECOM_HIPER_CREDITO_A_VISTA { get; set; }

        public decimal? ECOM_HIPER_DEBITO { get; set; }

        public decimal? ECOM_HIPER_PARC_2_6 { get; set; }

        public decimal? ECOM_HIPER_PARC_7_12 { get; set; }

        public decimal? ECOM_HIPER_CARNE { get; set; }

        public decimal? ECOM_HIPER_RECORRENTE { get; set; }
    }
}

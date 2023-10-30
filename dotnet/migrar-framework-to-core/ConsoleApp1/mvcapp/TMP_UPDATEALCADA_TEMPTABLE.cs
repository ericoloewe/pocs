namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.TMP_UPDATEALCADA_TEMPTABLE")]
    public partial class TMP_UPDATEALCADA_TEMPTABLE
    {
        public decimal? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string REGIONAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MCC { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal FATURAMENTO_MIN { get; set; }

        public decimal? FATURAMENTO_MAX { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal MDR_PONDERADA { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal TAXA_MIN_CRED_V { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TAXA_MIN_PARC_2_6 { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal TAXA_MIN_PARC_7_12 { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal TAXA_MIN_DEBITO { get; set; }

        public decimal? TAXA_MIN_CARNE { get; set; }

        public decimal? TAXA_MIN_RECORRENTE { get; set; }

        public decimal? TAXA_MIN_CREDIARIO { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime DATA_INSERT { get; set; }

        [StringLength(100)]
        public string BANDEIRA { get; set; }

        [StringLength(5)]
        public string ANTECIPACAO { get; set; }

        public decimal? TAXA_MIN_CRED_V_ECOM { get; set; }

        public decimal? TAXA_MIN_DEBITO_ECOM { get; set; }

        public decimal? TAXA_MIN_PARC_2_6_ECOM { get; set; }

        public decimal? TAXA_MIN_PARC_7_12_ECOM { get; set; }

        public decimal? TAXA_MIN_CARNE_ECOM { get; set; }

        public decimal? TAXA_MIN_RECORRENTE_ECOM { get; set; }

        public decimal? TAXA_MIN_CREDIARIO_ECOM { get; set; }

        public decimal? ID_COMBO_PROM { get; set; }

        [StringLength(1)]
        public string ANTEC_PONTUAL { get; set; }

        public decimal? ANTEC_PONTUAL_PERC { get; set; }

        [StringLength(10)]
        public string TIPO_RECEB { get; set; }

        public decimal? SUBSIDIO_PERC { get; set; }

        public decimal? DIST_PERC_FISICO { get; set; }

        public decimal? DIST_PERC_ECOMM { get; set; }

        public decimal? POS_GPRS_QTD { get; set; }

        public decimal? POS_DIGITAL { get; set; }

        public decimal? PINDPAD_QTD { get; set; }

        public decimal? CONECTIVIDADE_QTD { get; set; }

        public decimal? SGET_ALUG_SEM_BOBINA { get; set; }

        public decimal? SGET_ALUG_COM_BOBINA { get; set; }

        public decimal? CHECKOUT_MOVEL_QTD { get; set; }

        public decimal? ECOMM_QTD { get; set; }

        public decimal? ANTEC_AUTO_PERC { get; set; }
    }
}

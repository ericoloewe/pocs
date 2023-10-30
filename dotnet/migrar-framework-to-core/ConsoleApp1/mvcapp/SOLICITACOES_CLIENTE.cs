namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.SOLICITACOES_CLIENTE")]
    public partial class SOLICITACOES_CLIENTE
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [StringLength(100)]
        public string LOGIN { get; set; }

        [StringLength(100)]
        public string PERFIL { get; set; }

        [StringLength(100)]
        public string AREA { get; set; }

        [StringLength(100)]
        public string CARGO { get; set; }

        [StringLength(100)]
        public string REGIONAL { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDEM { get; set; }

        [StringLength(20)]
        public string CNPJ { get; set; }

        [StringLength(400)]
        public string RAZAO_SOCIAL { get; set; }

        [StringLength(100)]
        public string SUBRAMO { get; set; }

        [StringLength(100)]
        public string MCC { get; set; }

        [StringLength(100)]
        public string SEGMENTO { get; set; }

        [StringLength(100)]
        public string CEP_CLIENTE { get; set; }

        [StringLength(100)]
        public string REGIAO { get; set; }

        public decimal? IND_FRANQUIA { get; set; }

        public decimal? FILIAIS_FRANQUIAS { get; set; }

        [StringLength(100)]
        public string CONQUISTA_RETENCAO { get; set; }

        public decimal? TEMPO { get; set; }

        public decimal? FATURAMENTO { get; set; }

        public decimal? VOLUME_PRES { get; set; }

        public decimal? VOLUME_ECOM { get; set; }

        public decimal? FAT_PRES { get; set; }

        public decimal? FAT_ECOM { get; set; }

        public decimal? FAT_CRED_V_PRES { get; set; }

        public decimal? FAT_DEB_PRES { get; set; }

        public decimal? FAT_PARC_2_6_PRES { get; set; }

        public decimal? FAT_PARC_7_12_PRES { get; set; }

        public decimal? FAT_CARNE_PRES { get; set; }

        public decimal? FAT_RECORRENTE_PRES { get; set; }

        public decimal? FAT_CRED_V_ECOM { get; set; }

        public decimal? FAT_DEB_ECOM { get; set; }

        public decimal? FAT_PARC_2_6_ECOM { get; set; }

        public decimal? FAT_PARC_7_12_ECOM { get; set; }

        public decimal? FAT_CARNE_ECOM { get; set; }

        public decimal? FAT_RECORRENTE_ECOM { get; set; }

        public decimal? PRAZO_LIQ { get; set; }

        public decimal? SHARE_NEG { get; set; }

        public decimal? PORC_FAT_VISA { get; set; }

        public decimal? PORC_FAT_MASTER { get; set; }

        public decimal? PORC_FAT_ELO { get; set; }

        public decimal? PORC_FAT_AMEX { get; set; }

        public decimal? PORC_FAT_HIPER { get; set; }

        public decimal? PORC_FAT_HIPERCARD { get; set; }

        public decimal? TM_CRED_V { get; set; }

        public decimal? TM_DEB { get; set; }

        public decimal? TM_PARC_2_6 { get; set; }

        public decimal? TM_PARC_7_12 { get; set; }

        public decimal? TM_CARNE { get; set; }

        public decimal? TM_RECORRENTE { get; set; }

        public decimal? NUM_POS_DIAL { get; set; }

        public decimal? ALU_POS_DIAL { get; set; }

        public decimal? NUM_POS_GPRS { get; set; }

        public decimal? ALU_POS_GPRS { get; set; }

        public decimal? NUM_POS_BANDA_LARGA { get; set; }

        public decimal? ALU_POS_BANDA_LARGA { get; set; }

        public decimal? NUM_POS_DIGITAL { get; set; }

        public decimal? ALU_POS_DIGITAL { get; set; }

        public decimal? NUM_PINPADS { get; set; }

        public decimal? ALU_PINPADS { get; set; }

        public decimal? NUM_CONECT { get; set; }

        public decimal? ALU_CONECT { get; set; }

        public decimal? NUM_MINHA_LOJA_DIGITAL { get; set; }

        public decimal? ALU_MINHA_LOJA_DIGITAL { get; set; }

        public decimal? NUM_MAIS_GESTAO { get; set; }

        public decimal? ALU_MAIS_GESTAO { get; set; }

        public decimal? PORC_PLAT_BLA_GOLD_CORP { get; set; }

        public decimal? PORC_CLASS_INTER { get; set; }

        public decimal? PORC_REBATE { get; set; }

        public decimal? FAT_REBATE { get; set; }

        public decimal? FAT_MINIMO { get; set; }

        public decimal? PORC_PATROCINIO { get; set; }

        public decimal? FAT_PATROCINIO { get; set; }

        public decimal? ANTEC_VOLUME { get; set; }

        public decimal? ANTEC_PRAZO_MEDIO { get; set; }

        public decimal? ANTEC_PORC_CDI { get; set; }

        public decimal? ANTEC_TAXA_AM { get; set; }

        public decimal? REC_OI_FAT { get; set; }

        public decimal? REC_OI_COM_CLI { get; set; }

        public decimal? REC_CLARO_FAT { get; set; }

        public decimal? REC_CLARO_COM_CLI { get; set; }

        public decimal? REC_TIM_FAT { get; set; }

        public decimal? REC_TIM_COM_CLI { get; set; }

        public decimal? REC_VIVO_FAT { get; set; }

        public decimal? REC_VIVO_COM_CLI { get; set; }

        public decimal? REC_OUTROS_FAT { get; set; }

        public decimal? REC_OUTROS_COM_CLI { get; set; }

        public decimal? PRAZO_CORTE { get; set; }

        public decimal? PRAZO_PAGAM { get; set; }

        public decimal? PD_FAT_ANTIFRAUDE_CONC { get; set; }

        public decimal? PD_FAT_GATEWAY_CONC { get; set; }

        public decimal? PD_FAT_CONCILIDAOR_CONC { get; set; }

        public decimal? PD_FAT_COFRE_CONC { get; set; }

        public decimal? PD_RECORRENTE { get; set; }

        public decimal? PD_NUM_TRANS_CONC { get; set; }

        public decimal? PD_VOLUME_CONC { get; set; }

        public decimal? PD_TICKET_MEDIO_CONC { get; set; }

        public decimal? IND_TERMO_OBRIGATORIO { get; set; }

        public decimal? IND_EVIDENCIA_VALIDA { get; set; }

        [StringLength(50)]
        public string NOME_CONCORRENCIA { get; set; }

        public decimal? FAT_CREDIARIO_PRES { get; set; }

        public decimal? FAT_CREDIARIO_ECOM { get; set; }

        public decimal? TM_CREDIARIO { get; set; }

        [StringLength(300)]
        public string NOME_CRIADOR { get; set; }

        [StringLength(20)]
        public string TELEFONE { get; set; }

        [StringLength(500)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string AGENCIA { get; set; }

        public decimal? RECEBA_JA { get; set; }

        public decimal? TAXA_SERVICO { get; set; }

        public decimal? DIAS_RECEBA_JA { get; set; }

        public decimal? MULTA { get; set; }

        public decimal? IND_PRECIFICACION_DINAMICA { get; set; }

        public decimal? FREQ_FAT_GETNET { get; set; }

        public decimal? PRZLIQ_CRED_V_PRES { get; set; }

        public decimal? PRZLIQ_CRE_V_ECOM { get; set; }

        [StringLength(2)]
        public string ID_UF { get; set; }

        [Column("3ds")]
        public decimal? C3ds { get; set; }

        public decimal? FATURAMENTO_GETNET { get; set; }

        public decimal? FAT_GETNET { get; set; }
    }
}

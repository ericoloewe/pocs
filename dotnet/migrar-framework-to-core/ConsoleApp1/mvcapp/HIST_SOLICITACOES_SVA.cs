namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.HIST_SOLICITACOES_SVA")]
    public partial class HIST_SOLICITACOES_SVA
    {
        public DateTime? DATA_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_DIM_SVA { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ORDEM { get; set; }

        public decimal? TRANSACOES { get; set; }

        public decimal? CUSTO { get; set; }

        public decimal? RECEITA_BRUTA { get; set; }

        public decimal? RECEITA_LIQUIDA { get; set; }

        public decimal? RECEITA { get; set; }

        public decimal? VOUCHER_SODEXO_FAT { get; set; }

        public decimal? VOUCHER_SODEXO_RECEITA { get; set; }

        public decimal? VOUCHER_SODEXO_CUSTO { get; set; }

        public decimal? VOUCHER_ALELO_FAT { get; set; }

        public decimal? VOUCHER_ALELO_RECEITA { get; set; }

        public decimal? VOUCHER_ALELO_CUSTO { get; set; }

        public decimal? VOUCHER_VR_FAT { get; set; }

        public decimal? VOUCHER_VR_RECEITA { get; set; }

        public decimal? VOUCHER_VR_CUSTO { get; set; }

        public decimal? VOUCHER_BEN_FAT { get; set; }

        public decimal? VOUCHER_BEN_RECEITA { get; set; }

        public decimal? VOUCHER_BEN_CUSTO { get; set; }

        public decimal? VOUCHER_TICKET_FAT { get; set; }

        public decimal? VOUCHER_TICKET_RECEITA { get; set; }

        public decimal? VOUCHER_TICKET_CUSTO { get; set; }

        public decimal? VOUCHER_TICKETLOG_FAT { get; set; }

        public decimal? VOUCHER_TICKETLOG_RECEITA { get; set; }

        public decimal? VOUCHER_TICKETLOG_CUSTO { get; set; }

        public decimal? VOUCHER_BANESTES_FAT { get; set; }

        public decimal? VOUCHER_BANESTES_RECEITA { get; set; }

        public decimal? VOUCHER_BANESTES_CUSTO { get; set; }

        public decimal? VOUCHER_SOROCRED_FAT { get; set; }

        public decimal? VOUCHER_SOROCRED_RECEITA { get; set; }

        public decimal? VOUCHER_SOROCRED_CUSTO { get; set; }

        public decimal? VOUCHER_GOODCARD_FAT { get; set; }

        public decimal? VOUCHER_GOODCARD_RECEITA { get; set; }

        public decimal? VOUCHER_GOODCARD_CUSTO { get; set; }
    }
}

namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.PARAM_SVA")]
    public partial class PARAM_SVA
    {
        public decimal? VOUCHER_SODEXO_RECEITA { get; set; }

        public decimal? VOUCHER_SODEXO_CUSTO { get; set; }

        public decimal? VOUCHER_ALELO_RECEITA { get; set; }

        public decimal? VOUCHER_ALELO_CUSTO { get; set; }

        public decimal? VOUCHER_VR_RECEITA { get; set; }

        public decimal? VOUCHER_VR_CUSTO { get; set; }

        public decimal? VOUCHER_BEN_RECEITA { get; set; }

        public decimal? VOUCHER_BEN_CUSTO { get; set; }

        public decimal? VOUCHER_TICKET_RECEITA { get; set; }

        public decimal? VOUCHER_TICKET_CUSTO { get; set; }

        public decimal? VOUCHER_TICKETLOG_RECEITA { get; set; }

        public decimal? VOUCHER_TICKETLOG_CUSTO { get; set; }

        public decimal? VOUCHER_BANESTES_RECEITA { get; set; }

        public decimal? VOUCHER_BANESTES_CUSTO { get; set; }

        public decimal? VOUCHER_SOROCRED_RECEITA { get; set; }

        public decimal? VOUCHER_SOROCRED_CUSTO { get; set; }

        public decimal? VOUCHER_GOODCARD_RECEITA { get; set; }

        public decimal? VOUCHER_GOODCARD_CUSTO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_PARAM_SVA { get; set; }
    }
}

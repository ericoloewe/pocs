namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.VW_SOLICTECNOLOGIAS_1")]
    public partial class VW_SOLICTECNOLOGIAS_1
    {
        [Key]
        public decimal ID_SOLICITACAO { get; set; }

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

        public decimal? NUM_MAIS_GESTAO { get; set; }

        public decimal? ALU_MAIS_GESTAO { get; set; }

        public decimal? NUM_MINHA_LOJA_DIGITAL { get; set; }

        public decimal? ALU_MINHA_LOJA_DIGITAL { get; set; }

        public decimal? NUM_SUPERGET_ALU_SEM { get; set; }

        public decimal? ALU_SUPERGET_ALU_SEM { get; set; }

        public decimal? NUM_SUPERGET_ALU_COM { get; set; }

        public decimal? ALU_SUPERGET_ALU_COM { get; set; }

        public decimal? NUM_CHECKOUT_MOVEL { get; set; }

        public decimal? ALU_CHECKOUT_MOVEL { get; set; }

        public decimal? NUM_SUPERGET_VENDA_SEM { get; set; }

        public decimal? NUM_SUPERGET_VENDA_COM { get; set; }
    }
}

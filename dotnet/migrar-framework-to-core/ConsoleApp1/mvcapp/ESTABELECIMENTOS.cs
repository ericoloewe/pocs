namespace mvcapp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICING_NEG.ESTABELECIMENTOS")]
    public partial class ESTABELECIMENTOS
    {
        [Key]
        public decimal ID_ESTABELECIMENTO { get; set; }

        [StringLength(50)]
        public string CNPJ_BASICO { get; set; }

        [StringLength(50)]
        public string CNPJ_ORDEM { get; set; }

        [StringLength(50)]
        public string CNPJ_DV { get; set; }

        [StringLength(50)]
        public string INDENTIFICADOR_MATRIZ_FILIAL { get; set; }

        public string NOME_FANTASIA_0 { get; set; }

        public string SITUACAO_CADASTRAL_0 { get; set; }

        public string DATA_SITUACAO_CADASTRAL { get; set; }

        public string MOTIVO_SITUACAO_CADASTRAL { get; set; }

        public string NOME_CIDADE_EXTERIOR { get; set; }

        public string PAIS { get; set; }

        public string DATA_INICIO_ATIVIDADE { get; set; }

        public string CNAE_FISCAL_PRINCIPAL_0 { get; set; }

        public string CNAE_FISCAL_SECUNDARIA { get; set; }

        public string TIPO_LOGRADOURO { get; set; }

        public string LOGRADOURO { get; set; }

        public string NUMERO { get; set; }

        public string COMPLEMENTO { get; set; }

        public string BAIRRO { get; set; }

        [StringLength(250)]
        public string CEP { get; set; }

        [StringLength(250)]
        public string UF { get; set; }

        public string MUNICIPIO { get; set; }

        public string DD1 { get; set; }

        public string TELEFONE1 { get; set; }

        public string DDD2 { get; set; }

        public string TELEFONE2 { get; set; }

        public string DDD_FAX { get; set; }

        public string FAX { get; set; }

        public string CORREIO_ELETRONICO { get; set; }

        public string SITUACAO_ESPECIAL { get; set; }

        public string DATA_SITUACAO_ESPECIAL { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(500)]
        public string NOME_FANTASIA { get; set; }

        [StringLength(500)]
        public string SITUACAO_CADASTRAL { get; set; }

        [StringLength(500)]
        public string CNAE_FISCAL_PRINCIPAL { get; set; }
    }
}

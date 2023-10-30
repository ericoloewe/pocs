using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace mvcapp
{
    public partial class ModelCF : DbContext
    {
        public ModelCF()
            : base("name=ModelCF")
        {
        }

        public virtual DbSet<ADM_APITHROTTLE> ADM_APITHROTTLE { get; set; }
        public virtual DbSet<ALCADA> ALCADA { get; set; }
        public virtual DbSet<ALCADA_CALLCENTER> ALCADA_CALLCENTER { get; set; }
        public virtual DbSet<ALCADA_COMERCIAL> ALCADA_COMERCIAL { get; set; }
        public virtual DbSet<ALCADA_OUVIDORIA> ALCADA_OUVIDORIA { get; set; }
        public virtual DbSet<ALCADA_PRICING> ALCADA_PRICING { get; set; }
        public virtual DbSet<ALCADA_PRICING_FORMULA> ALCADA_PRICING_FORMULA { get; set; }
        public virtual DbSet<ALCADA_PRICING_NOVA> ALCADA_PRICING_NOVA { get; set; }
        public virtual DbSet<ALCADA_PRICING_PERFIL> ALCADA_PRICING_PERFIL { get; set; }
        public virtual DbSet<ALCADA_REGIONAL> ALCADA_REGIONAL { get; set; }
        public virtual DbSet<ANALYTICS_CABECALHO> ANALYTICS_CABECALHO { get; set; }
        public virtual DbSet<ANTECIPACAOSEGM> ANTECIPACAOSEGM { get; set; }
        public virtual DbSet<AUMENTO_TAXAS> AUMENTO_TAXAS { get; set; }
        public virtual DbSet<CNAE_AUDITORIA> CNAE_AUDITORIA { get; set; }
        public virtual DbSet<CNAE_CNPJ> CNAE_CNPJ { get; set; }
        public virtual DbSet<CNAE_LISTA_PROC> CNAE_LISTA_PROC { get; set; }
        public virtual DbSet<CNAE_MCC> CNAE_MCC { get; set; }
        public virtual DbSet<CNAE_STATUS> CNAE_STATUS { get; set; }
        public virtual DbSet<CNPJ_BLINDADO_ATACADO> CNPJ_BLINDADO_ATACADO { get; set; }
        public virtual DbSet<CNPJ_TAXAS_PREAPROVADAS> CNPJ_TAXAS_PREAPROVADAS { get; set; }
        public virtual DbSet<CNPJ_TAXAS_PREAPROVADAS_HISTORICO> CNPJ_TAXAS_PREAPROVADAS_HISTORICO { get; set; }
        public virtual DbSet<COMBO_PROM> COMBO_PROM { get; set; }
        public virtual DbSet<COMERCIAIS_GETNET> COMERCIAIS_GETNET { get; set; }
        public virtual DbSet<CONFIGURACAO_TAXAS_BANDEIRAS> CONFIGURACAO_TAXAS_BANDEIRAS { get; set; }
        public virtual DbSet<DIM_AGENCIAS> DIM_AGENCIAS { get; set; }
        public virtual DbSet<DIM_ALTER_TAXAS> DIM_ALTER_TAXAS { get; set; }
        public virtual DbSet<DIM_BANDEIRAS> DIM_BANDEIRAS { get; set; }
        public virtual DbSet<DIM_ESTADO_SOLICITACAO> DIM_ESTADO_SOLICITACAO { get; set; }
        public virtual DbSet<DIM_FERIADOS> DIM_FERIADOS { get; set; }
        public virtual DbSet<DIM_GRID_ROWS> DIM_GRID_ROWS { get; set; }
        public virtual DbSet<DIM_MODALIDADE> DIM_MODALIDADE { get; set; }
        public virtual DbSet<DIM_PARCEIROS> DIM_PARCEIROS { get; set; }
        public virtual DbSet<DIM_PERFILES_AD> DIM_PERFILES_AD { get; set; }
        public virtual DbSet<DIM_PERFILES_PRICING> DIM_PERFILES_PRICING { get; set; }
        public virtual DbSet<DIM_PERIODOS> DIM_PERIODOS { get; set; }
        public virtual DbSet<DIM_RAMOS> DIM_RAMOS { get; set; }
        public virtual DbSet<DIM_RECEBA_JA> DIM_RECEBA_JA { get; set; }
        public virtual DbSet<DIM_REPREC_EVENTO> DIM_REPREC_EVENTO { get; set; }
        public virtual DbSet<DIM_SEGMENTOS> DIM_SEGMENTOS { get; set; }
        public virtual DbSet<DIM_SIM_NAO> DIM_SIM_NAO { get; set; }
        public virtual DbSet<DIM_TAXAS_ENCARTE> DIM_TAXAS_ENCARTE { get; set; }
        public virtual DbSet<DIM_TIPO_TAXA> DIM_TIPO_TAXA { get; set; }
        public virtual DbSet<DIM_UNIDADES_FEDERALES> DIM_UNIDADES_FEDERALES { get; set; }
        public virtual DbSet<DIM_USUARIOS_PRICING_ACESSOS> DIM_USUARIOS_PRICING_ACESSOS { get; set; }
        public virtual DbSet<ELMAH_ERROR> ELMAH_ERROR { get; set; }
        public virtual DbSet<ESTABELECIMENTOS> ESTABELECIMENTOS { get; set; }
        public virtual DbSet<FATURAMENTO_MIN_MES> FATURAMENTO_MIN_MES { get; set; }
        public virtual DbSet<FILAGERENCIAL> FILAGERENCIAL { get; set; }
        public virtual DbSet<GRIDS> GRIDS { get; set; }
        public virtual DbSet<GRIDS_DIMENSION_COLUMNS> GRIDS_DIMENSION_COLUMNS { get; set; }
        public virtual DbSet<GRIDS_DIMENSION_ROWS> GRIDS_DIMENSION_ROWS { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_ANTECIPACAO> HIST_SOLICITACOES_ANTECIPACAO { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_ARQUIVOS> HIST_SOLICITACOES_ARQUIVOS { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_CABECALHO> HIST_SOLICITACOES_CABECALHO { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_CLIENTE> HIST_SOLICITACOES_CLIENTE { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_DEFESA> HIST_SOLICITACOES_DEFESA { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_GRUPO> HIST_SOLICITACOES_GRUPO { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_MDR> HIST_SOLICITACOES_MDR { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_PLASTICOS> HIST_SOLICITACOES_PLASTICOS { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_SUBSIDIO> HIST_SOLICITACOES_SUBSIDIO { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_SVA> HIST_SOLICITACOES_SVA { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_TAXAS> HIST_SOLICITACOES_TAXAS { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_TAXAS_SEM_DESC> HIST_SOLICITACOES_TAXAS_SEM_DESC { get; set; }
        public virtual DbSet<HIST_SOLICITACOES_TECNOLOGIAS> HIST_SOLICITACOES_TECNOLOGIAS { get; set; }
        public virtual DbSet<LISTA_SOLICITACOES_FINALIZADAS> LISTA_SOLICITACOES_FINALIZADAS { get; set; }
        public virtual DbSet<LOG> LOG { get; set; }
        public virtual DbSet<LOG_PROCEDURES> LOG_PROCEDURES { get; set; }
        public virtual DbSet<LOG_SERVICE_ANTECIPACAO> LOG_SERVICE_ANTECIPACAO { get; set; }
        public virtual DbSet<MAJORACAO> MAJORACAO { get; set; }
        public virtual DbSet<MIX_BANDEIRAS> MIX_BANDEIRAS { get; set; }
        public virtual DbSet<MIX_MODALIDADE_REGIONAL> MIX_MODALIDADE_REGIONAL { get; set; }
        public virtual DbSet<PAR_MOTORPLANILHA> PAR_MOTORPLANILHA { get; set; }
        public virtual DbSet<PARAM_SVA> PARAM_SVA { get; set; }
        public virtual DbSet<PARAMS_INTEGRACAO> PARAMS_INTEGRACAO { get; set; }
        public virtual DbSet<PARAMS_LOG> PARAMS_LOG { get; set; }
        public virtual DbSet<PILOTO_PRECIFICACAODINAMICA> PILOTO_PRECIFICACAODINAMICA { get; set; }
        public virtual DbSet<PILOTO_PRECIFICACAODINAMICAUSUARIO> PILOTO_PRECIFICACAODINAMICAUSUARIO { get; set; }
        public virtual DbSet<REPRECIFICACAO> REPRECIFICACAO { get; set; }
        public virtual DbSet<SEGMENTO_TERMO> SEGMENTO_TERMO { get; set; }
        public virtual DbSet<SOLICITACOES_ANTECIPACAO> SOLICITACOES_ANTECIPACAO { get; set; }
        public virtual DbSet<SOLICITACOES_CABECALHO> SOLICITACOES_CABECALHO { get; set; }
        public virtual DbSet<SOLICITACOES_CLIENTE> SOLICITACOES_CLIENTE { get; set; }
        public virtual DbSet<SOLICITACOES_DEFESA> SOLICITACOES_DEFESA { get; set; }
        public virtual DbSet<SOLICITACOES_GRUPO> SOLICITACOES_GRUPO { get; set; }
        public virtual DbSet<SOLICITACOES_MDR> SOLICITACOES_MDR { get; set; }
        public virtual DbSet<SOLICITACOES_PLASTICOS> SOLICITACOES_PLASTICOS { get; set; }
        public virtual DbSet<SOLICITACOES_REPREC> SOLICITACOES_REPREC { get; set; }
        public virtual DbSet<SOLICITACOES_SUBSIDIO> SOLICITACOES_SUBSIDIO { get; set; }
        public virtual DbSet<SOLICITACOES_SVA> SOLICITACOES_SVA { get; set; }
        public virtual DbSet<SOLICITACOES_TAXAS> SOLICITACOES_TAXAS { get; set; }
        public virtual DbSet<SOLICITACOES_TAXAS_SEM_DESC> SOLICITACOES_TAXAS_SEM_DESC { get; set; }
        public virtual DbSet<SOLICITACOES_TECNOLOGIAS> SOLICITACOES_TECNOLOGIAS { get; set; }
        public virtual DbSet<SURVEY_CABECALHO> SURVEY_CABECALHO { get; set; }
        public virtual DbSet<SURVEY_CONTROLE_VISUALIZACAO> SURVEY_CONTROLE_VISUALIZACAO { get; set; }
        public virtual DbSet<SURVEY_QUESTOES> SURVEY_QUESTOES { get; set; }
        public virtual DbSet<SURVEY_RESPOSTAS> SURVEY_RESPOSTAS { get; set; }
        public virtual DbSet<SURVEY_RESPOSTAS_USUARIO> SURVEY_RESPOSTAS_USUARIO { get; set; }
        public virtual DbSet<TAXAANTECIPACAO> TAXAANTECIPACAO { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO> TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_NIVEL> TAXAS_PREAPROVADAS_NIVEL { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_REJEITADAS> TAXAS_PREAPROVADAS_REJEITADAS { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_UPLOAD> TAXAS_PREAPROVADAS_UPLOAD { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO> TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO { get; set; }
        public virtual DbSet<TAXAS_PREAPROVADAS_UPLOAD_STATUS> TAXAS_PREAPROVADAS_UPLOAD_STATUS { get; set; }
        public virtual DbSet<TIPOANTECIPACAO> TIPOANTECIPACAO { get; set; }
        public virtual DbSet<TMP_BASE> TMP_BASE { get; set; }
        public virtual DbSet<USUARIOS_PRICING> USUARIOS_PRICING { get; set; }
        public virtual DbSet<CNAE_RESULTADO> CNAE_RESULTADO { get; set; }
        public virtual DbSet<DIM_TECNOLOGIAS> DIM_TECNOLOGIAS { get; set; }
        public virtual DbSet<HIERARQUIA_COMERCIAIS_GETNET> HIERARQUIA_COMERCIAIS_GETNET { get; set; }
        public virtual DbSet<PARAMS_GESTAO> PARAMS_GESTAO { get; set; }
        public virtual DbSet<PARM_HISTORICAS> PARM_HISTORICAS { get; set; }
        public virtual DbSet<TMP_ALCADA_IMPORTA> TMP_ALCADA_IMPORTA { get; set; }
        public virtual DbSet<TMP_SERVICOS_ADICIONAIS> TMP_SERVICOS_ADICIONAIS { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_BANDEIRAS> TMP_SOLICITACOES_BANDEIRAS { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_FATURAMENTOS> TMP_SOLICITACOES_FATURAMENTOS { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_PLATINIZACAO> TMP_SOLICITACOES_PLATINIZACAO { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_TAXASAPROV> TMP_SOLICITACOES_TAXASAPROV { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_TECNOLOGIAS> TMP_SOLICITACOES_TECNOLOGIAS { get; set; }
        public virtual DbSet<TMP_SOLICITACOES_TICKETS> TMP_SOLICITACOES_TICKETS { get; set; }
        public virtual DbSet<TMP_UPDATEALCADA_TEMPTABLE> TMP_UPDATEALCADA_TEMPTABLE { get; set; }
        public virtual DbSet<TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE> TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE { get; set; }
        public virtual DbSet<TMP_UPDATEPARAMSGESTAO_TEMPTABLE> TMP_UPDATEPARAMSGESTAO_TEMPTABLE { get; set; }
        public virtual DbSet<TMP_UPDATETAXAS_TEMPTABLE> TMP_UPDATETAXAS_TEMPTABLE { get; set; }
        public virtual DbSet<VW_ALERTAS_ATENDIMENTO> VW_ALERTAS_ATENDIMENTO { get; set; }
        public virtual DbSet<VW_SOLICITACOES_CABECALHO_HIST> VW_SOLICITACOES_CABECALHO_HIST { get; set; }
        public virtual DbSet<VW_SOLICITACOES_CABECALHO_TRANS> VW_SOLICITACOES_CABECALHO_TRANS { get; set; }
        public virtual DbSet<VW_SOLICITACOES_CLIENTE_HIST> VW_SOLICITACOES_CLIENTE_HIST { get; set; }
        public virtual DbSet<VW_SOLICITACOES_CLIENTE_TRANS> VW_SOLICITACOES_CLIENTE_TRANS { get; set; }
        public virtual DbSet<VW_SOLICTECNOLOGIAS_1> VW_SOLICTECNOLOGIAS_1 { get; set; }
        public virtual DbSet<VW_SOLICTECNOLOGIAS_2> VW_SOLICTECNOLOGIAS_2 { get; set; }
        public virtual DbSet<VW_SOLTAXA_APROV_MAX> VW_SOLTAXA_APROV_MAX { get; set; }
        public virtual DbSet<VW_SOLTAXA_CONC_MAX> VW_SOLTAXA_CONC_MAX { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADM_APITHROTTLE>()
                .Property(e => e.ENDPOINT)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.MDR_PONDERADA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CRED_V)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.BANDEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ANTECIPACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CRED_V_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_DEBITO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_PARC_2_6_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_PARC_7_12_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CARNE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_RECORRENTE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TAXA_MIN_CREDIARIO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ANTEC_PONTUAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ANTEC_PONTUAL_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.TIPO_RECEB)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.SUBSIDIO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.DIST_PERC_FISICO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.DIST_PERC_ECOMM)
                .HasPrecision(6, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.POS_GPRS_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.PINDPAD_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.CONECTIVIDADE_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.SGET_ALUG_SEM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.SGET_ALUG_COM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.CHECKOUT_MOVEL_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ECOMM_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.ANTEC_AUTO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.DESCONTO_MAX)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ALCADA>()
                .Property(e => e.CODIGO_CAMPANHA)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.MDR_BRUTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_DEB)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_CRED)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_PARCE_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_RECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_CALLCENTER>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.COD_UNIORG_REG)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.DESC_REDE)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.DESC_REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.MDR_BRUTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_DEB)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_CRED)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_PARCE_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_RECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_COMERCIAL>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.MDR_BRUTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_DEB)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_CRED)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_PARCE_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_RECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_OUVIDORIA>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.ALCADA)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.MOL_SE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.BAI_SE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.MDR_L_SE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.MOL_CE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.BAI_CE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.MDR_L_CE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.MAX_DESC_ALU)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_PRICING>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_FORMULA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_FORMULA>()
                .Property(e => e.VAL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING_FORMULA>()
                .Property(e => e.TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING_FORMULA>()
                .Property(e => e.COD_TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_NOVA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_NOVA>()
                .Property(e => e.ID_SEGMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_NOVA>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING_NOVA>()
                .Property(e => e.VALOR)
                .HasPrecision(20, 4);

            modelBuilder.Entity<ALCADA_PRICING_NOVA>()
                .Property(e => e.ID_FORMULA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_PERFIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALCADA_PRICING_PERFIL>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING_PERFIL>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_PRICING_PERFIL>()
                .Property(e => e.MARGEM_COM_EVIDENCIA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_PRICING_PERFIL>()
                .Property(e => e.MARGEM_SEM_EVIDENCIA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.UNIORG_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.COD_UNIORG_REG)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.DESC_REDE)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.DESC_REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.MDR_BRUTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_DEB)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_CRED)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_PARCE_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_RECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ALCADA_REGIONAL>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.ID_ANALYTICS_CABECALHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.SO)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.IDIOMA)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.BROWSER)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.TAMANHO_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.TAMANHO_JANELA)
                .IsUnicode(false);

            modelBuilder.Entity<ANALYTICS_CABECALHO>()
                .Property(e => e.VERSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ANTECIPACAOSEGM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ANTECIPACAOSEGM>()
                .Property(e => e.SEGMENTOID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ANTECIPACAOSEGM>()
                .Property(e => e.TIPOANTECIPACAOID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ANTECIPACAOSEGM>()
                .Property(e => e.TAXAANTECIPACAOID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ANTECIPACAOSEGM>()
                .Property(e => e.IDSTIPOANTECIPACAO)
                .IsUnicode(false);

            modelBuilder.Entity<AUMENTO_TAXAS>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<AUMENTO_TAXAS>()
                .Property(e => e.PCT_FAT_REAL)
                .HasPrecision(5, 4);

            modelBuilder.Entity<AUMENTO_TAXAS>()
                .Property(e => e.AUMENTO_TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<AUMENTO_TAXAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_AUDITORIA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_AUDITORIA>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_AUDITORIA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE_AUDITORIA>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_CNPJ>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_CNPJ>()
                .Property(e => e.CNAE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_CNPJ>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE_LISTA_PROC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_LISTA_PROC>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_LISTA_PROC>()
                .Property(e => e.NUMTENTATIVAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_MCC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_MCC>()
                .Property(e => e.CNAE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_MCC>()
                .Property(e => e.MCC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_MCC>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE_STATUS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_STATUS>()
                .Property(e => e.CODSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_STATUS>()
                .Property(e => e.DESCSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE_STATUS>()
                .HasMany(e => e.CNAE_AUDITORIA)
                .WithOptional(e => e.CNAE_STATUS)
                .HasForeignKey(e => e.IDSTATUS);

            modelBuilder.Entity<CNAE_STATUS>()
                .HasMany(e => e.SOLICITACOES_CABECALHO)
                .WithOptional(e => e.CNAE_STATUS)
                .HasForeignKey(e => e.IDSTATUS);

            modelBuilder.Entity<CNPJ_BLINDADO_ATACADO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNPJ_BLINDADO_ATACADO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_BLINDADO_ATACADO>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_BLINDADO_ATACADO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.FAT_CRED)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.FAT_PARC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.FAT_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CRED_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_DEB_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CARNE_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_RECO_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.SUBSIDIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.PRAZO_LIQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.CODIGO_CONTROLE)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.NIVELID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.ID_CNPJ_TAXAS_PREAPROVADAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.ANTECIPACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.ANTEC_AUTO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.ANTEC_PONTUAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS>()
                .Property(e => e.ANTEC_PONTUAL_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.FAT_CRED)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.FAT_PARC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.FAT_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CRED_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_DEB_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_2_6_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_PARC_7_12_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CARNE_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_RECO_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.SUBSIDIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.CODIGO_CONTROLE)
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.TAXA_PREAP_CREDIARIO_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.ANTECIPACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.ANTEC_AUTO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.ANTEC_PONTUAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CNPJ_TAXAS_PREAPROVADAS_HISTORICO>()
                .Property(e => e.ANTEC_PONTUAL_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.FRASE_PROM_CABECALHO)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.FRASE_PROM_RODAPE)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.REGULAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.COD_CAMPANHA)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .Property(e => e.COD_OFERTA)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO_PROM>()
                .HasMany(e => e.ALCADA)
                .WithOptional(e => e.COMBO_PROM)
                .HasForeignKey(e => e.ID_COMBO_PROM);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.MATRICULA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<COMERCIAIS_GETNET>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURACAO_TAXAS_BANDEIRAS>()
                .Property(e => e.ID_CONFIGURACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONFIGURACAO_TAXAS_BANDEIRAS>()
                .Property(e => e.ID_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.UNIORG_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.NOME_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.RED)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.UNIORG_REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_AGENCIAS>()
                .Property(e => e.COD_REDE)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_ALTER_TAXAS>()
                .Property(e => e.TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_BANDEIRAS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(20, 0);

            modelBuilder.Entity<DIM_BANDEIRAS>()
                .Property(e => e.DESC_BANDEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_BANDEIRAS>()
                .Property(e => e.IMAGEM)
                .IsFixedLength();

            modelBuilder.Entity<DIM_BANDEIRAS>()
                .Property(e => e.SHORTNAME)
                .IsFixedLength();

            modelBuilder.Entity<DIM_BANDEIRAS>()
                .HasMany(e => e.CONFIGURACAO_TAXAS_BANDEIRAS)
                .WithRequired(e => e.DIM_BANDEIRAS)
                .HasForeignKey(e => e.ID_BANDEIRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.COD_ESTADO)
                .HasPrecision(20, 0);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.DESC_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.COD_GRUPO_ESTADO)
                .HasPrecision(20, 0);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.DESC_GRUPO_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.DESC_ESTADO_MESA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_ESTADO_SOLICITACAO>()
                .Property(e => e.DESCRIP_ESTADO_MESA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_FERIADOS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_FERIADOS>()
                .Property(e => e.ID)
                .HasPrecision(30, 0);

            modelBuilder.Entity<DIM_GRID_ROWS>()
                .Property(e => e.COD_ROW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_GRID_ROWS>()
                .Property(e => e.TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_GRID_ROWS>()
                .Property(e => e.COD_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_GRID_ROWS>()
                .HasMany(e => e.GRIDS_DIMENSION_ROWS)
                .WithRequired(e => e.DIM_GRID_ROWS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIM_MODALIDADE>()
                .Property(e => e.DESC_MODALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_MODALIDADE>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_MODALIDADE>()
                .HasMany(e => e.GRIDS_DIMENSION_COLUMNS)
                .WithRequired(e => e.DIM_MODALIDADE)
                .HasForeignKey(e => e.COD_COLUMN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.ID_PARCEIRO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.ID_SEGMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.DESC_PARCEIRO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PARCEIROS>()
                .Property(e => e.AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PERFILES_AD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PERFILES_AD>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PERFILES_AD>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PERFILES_AD>()
                .HasMany(e => e.DIM_PERFILES_PRICING)
                .WithOptional(e => e.DIM_PERFILES_AD)
                .HasForeignKey(e => e.PERFIL_AD);

            modelBuilder.Entity<DIM_PERFILES_PRICING>()
                .Property(e => e.ID_PERFIL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PERFILES_PRICING>()
                .Property(e => e.ALCADA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PERFILES_PRICING>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_PERFILES_PRICING>()
                .Property(e => e.PERFIL_AD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PERIODOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PERIODOS>()
                .Property(e => e.NUM_DIAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_PERIODOS>()
                .Property(e => e.NUM_MESES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_RAMOS>()
                .Property(e => e.ID_RAMO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_RAMOS>()
                .Property(e => e.DESC_RAMO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_RECEBA_JA>()
                .Property(e => e.IND_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_RECEBA_JA>()
                .Property(e => e.DIAS_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_REPREC_EVENTO>()
                .Property(e => e.ID_DIM_REPREC_EVENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_REPREC_EVENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .Property(e => e.ID_SEGMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .Property(e => e.COD_SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .Property(e => e.DESC_SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .HasMany(e => e.ANTECIPACAOSEGM)
                .WithRequired(e => e.DIM_SEGMENTOS)
                .HasForeignKey(e => e.SEGMENTOID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIM_SEGMENTOS>()
                .HasMany(e => e.SEGMENTO_TERMO)
                .WithRequired(e => e.DIM_SEGMENTOS)
                .HasForeignKey(e => e.SEGMENTOID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIM_SIM_NAO>()
                .Property(e => e.SIM_NAO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_TAXAS_ENCARTE>()
                .Property(e => e.TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_TAXAS_ENCARTE>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_TAXAS_ENCARTE>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<DIM_TIPO_TAXA>()
                .Property(e => e.COD_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_TIPO_TAXA>()
                .Property(e => e.DESC_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_UNIDADES_FEDERALES>()
                .Property(e => e.ID_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_UNIDADES_FEDERALES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_UNIDADES_FEDERALES>()
                .Property(e => e.REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_USUARIOS_PRICING_ACESSOS>()
                .Property(e => e.ID)
                .HasPrecision(1, 1);

            modelBuilder.Entity<ELMAH_ERROR>()
                .Property(e => e.STATUSCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ELMAH_ERROR>()
                .Property(e => e.SEQUENCE)
                .HasPrecision(1, 1);

            modelBuilder.Entity<ELMAH_ERROR>()
                .Property(e => e.ALLXML)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.ID_ESTABELECIMENTO)
                .HasPrecision(1, 1);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNPJ_BASICO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNPJ_ORDEM)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNPJ_DV)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.INDENTIFICADOR_MATRIZ_FILIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.NOME_FANTASIA_0)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.SITUACAO_CADASTRAL_0)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DATA_SITUACAO_CADASTRAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.MOTIVO_SITUACAO_CADASTRAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.NOME_CIDADE_EXTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DATA_INICIO_ATIVIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNAE_FISCAL_PRINCIPAL_0)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNAE_FISCAL_SECUNDARIA)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.TIPO_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DD1)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.TELEFONE1)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DDD2)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.TELEFONE2)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DDD_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CORREIO_ELETRONICO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.SITUACAO_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.DATA_SITUACAO_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.NOME_FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.SITUACAO_CADASTRAL)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABELECIMENTOS>()
                .Property(e => e.CNAE_FISCAL_PRINCIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<FATURAMENTO_MIN_MES>()
                .Property(e => e.ID_AREA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FATURAMENTO_MIN_MES>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<FATURAMENTO_MIN_MES>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<FATURAMENTO_MIN_MES>()
                .Property(e => e.ID)
                .HasPrecision(1, 1);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.TIPODEENVIO)
                .IsUnicode(false);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.IDSOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.NUMEROTENTATIVAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.IDREPRECIFICACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.ID)
                .HasPrecision(1, 1);

            modelBuilder.Entity<FILAGERENCIAL>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<GRIDS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRIDS>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GRIDS>()
                .HasMany(e => e.GRIDS_DIMENSION_COLUMNS)
                .WithRequired(e => e.GRIDS)
                .HasForeignKey(e => e.ID_GRIDS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRIDS>()
                .HasMany(e => e.GRIDS_DIMENSION_ROWS)
                .WithRequired(e => e.GRIDS)
                .HasForeignKey(e => e.ID_GRIDS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRIDS_DIMENSION_COLUMNS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS_DIMENSION_COLUMNS>()
                .Property(e => e.ID_GRIDS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS_DIMENSION_COLUMNS>()
                .Property(e => e.COD_COLUMN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS_DIMENSION_ROWS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS_DIMENSION_ROWS>()
                .Property(e => e.ID_GRIDS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRIDS_DIMENSION_ROWS>()
                .Property(e => e.COD_ROW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_PORC_VOLUME)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_SPREAD)
                .HasPrecision(6, 5);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_TAXA)
                .HasPrecision(6, 5);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_AUTO_TAXA)
                .HasPrecision(6, 5);

            modelBuilder.Entity<HIST_SOLICITACOES_ARQUIVOS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_ARQUIVOS>()
                .Property(e => e.ARQUIVO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_ARQUIVOS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ULTIMA_ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ULTIMO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.PRIMEIRO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.PRIMEIRA_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_PARCEIRO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.TIPO_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_SIMULACAO_EFETIVADA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.TERMO_ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_CNPJ_TAXAS_PREAPROVADAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.SUBRAMO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.CEP_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_FRANQUIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FILIAIS_FRANQUIAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.CONQUISTA_RETENCAO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TEMPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.VOLUME_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.VOLUME_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CRED_V_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_DEB_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_2_6_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_7_12_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CARNE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_RECORRENTE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CRED_V_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_DEB_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_2_6_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_7_12_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CARNE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_RECORRENTE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_LIQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.SHARE_NEG)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_MASTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CRED_V)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_PARC_2_6)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_PARC_7_12)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CARNE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_PLAT_BLA_GOLD_CORP)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_CLASS_INTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_REBATE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_REBATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_MINIMO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_PATROCINIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PATROCINIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_VOLUME)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_TAXA_AM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OI_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OI_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_CLARO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_CLARO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_TIM_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_TIM_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_VIVO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_VIVO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OUTROS_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OUTROS_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_CORTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_PAGAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_ANTIFRAUDE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_GATEWAY_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_CONCILIDAOR_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_COFRE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_NUM_TRANS_CONC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_VOLUME_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_TICKET_MEDIO_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_TERMO_OBRIGATORIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_EVIDENCIA_VALIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NOME_CONCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CREDIARIO_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CREDIARIO_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CREDIARIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.NOME_CRIADOR)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.TAXA_SERVICO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.DIAS_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_PRECIFICACION_DINAMICA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FREQ_FAT_GETNET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PRZLIQ_CRED_V_PRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.PRZLIQ_CRE_V_ECOM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.ID_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.C3ds)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FATURAMENTO_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_DEFESA>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_DEFESA>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_DEFESA>()
                .Property(e => e.ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_DEFESA>()
                .Property(e => e.DEFESA_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_DEFESA>()
                .Property(e => e.TEXTO_MESA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_GRUPO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_GRUPO>()
                .Property(e => e.CNPJ_MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_GRUPO>()
                .Property(e => e.CNPJ_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_GRUPO>()
                .Property(e => e.ADICIONAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.MDR_LIQUIDA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.BAI)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.MOL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.ID_FORMULA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_MDR>()
                .Property(e => e.VALOR_FORMULA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.ID_PLASTICO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.PERC_PLASTICO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_PLASTICOS>()
                .Property(e => e.PERC_REF)
                .HasPrecision(6, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_SUBSIDIO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SUBSIDIO>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SUBSIDIO>()
                .Property(e => e.PCT_SUBSIDIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_SUBSIDIO>()
                .Property(e => e.DESC_SUBSIDIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.ID_DIM_SVA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.TRANSACOES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.CUSTO)
                .HasPrecision(20, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.RECEITA_BRUTA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.RECEITA_LIQUIDA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.COD_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.IND_ECOMMERCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.IND_ECOMMERCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<HIST_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.COD_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.NUMERO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIST_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.VALOR_ALUGUEL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.REGIONAL_ALTERADA)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.FATURAMENTO_GETNET)
                .HasPrecision(20, 2);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.ESTADO_PORTAL)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.ESTADO_MESA)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<LISTA_SOLICITACOES_FINALIZADAS>()
                .Property(e => e.LISTA_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.ID_LOG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.MENSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_PROCEDURES>()
                .Property(e => e.ID_LOG_PROCEDURES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_PROCEDURES>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_PROCEDURES>()
                .Property(e => e.PARAMETROS)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.ID_LOG_SERVICE_ANTECIPACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.EC)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.ETAPA)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.SUCESSO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.DETALHES)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_SERVICE_ANTECIPACAO>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.AMEX_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ELO_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.HIPER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MAJORACAO>()
                .Property(e => e.ECOM_HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.MCC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_MC)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_BANDEIRAS>()
                .Property(e => e.PCT_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.MCC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_V_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_2_6_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_7_12_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_DEB_V_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CARNE_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_RECO_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_V_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_2_6_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CRED_7_12_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_DEB_V_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_CARNE_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<MIX_MODALIDADE_REGIONAL>()
                .Property(e => e.PCT_RECO_ECO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<PAR_MOTORPLANILHA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PAR_MOTORPLANILHA>()
                .Property(e => e.UNIORG)
                .IsUnicode(false);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_SODEXO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_SODEXO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_ALELO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_ALELO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_VR_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_VR_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_BEN_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_BEN_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_TICKET_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_TICKET_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_BANESTES_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_BANESTES_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PARAM_SVA>()
                .Property(e => e.ID_PARAM_SVA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMS_INTEGRACAO>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMS_INTEGRACAO>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMS_LOG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMS_LOG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMS_LOG>()
                .Property(e => e.ACTION)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMS_LOG>()
                .Property(e => e.TABELA)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMS_LOG>()
                .Property(e => e.INFO)
                .IsUnicode(false);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICA>()
                .Property(e => e.UNIORG_REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICA>()
                .Property(e => e.UNIORG_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICA>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICAUSUARIO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICAUSUARIO>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<PILOTO_PRECIFICACAODINAMICAUSUARIO>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ID_REPRECIFICACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ECOMM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ID_DIM_REPREC_EVENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.OLD_HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.ELOPARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.AMEXPARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<REPRECIFICACAO>()
                .Property(e => e.HIPERPARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SEGMENTO_TERMO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SEGMENTO_TERMO>()
                .Property(e => e.SEGMENTOID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SEGMENTO_TERMO>()
                .Property(e => e.REQUERTERMO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SEGMENTO_TERMO>()
                .Property(e => e.ATIVA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.IND_ANTECIPACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_PORC_VOLUME)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_SPREAD)
                .HasPrecision(6, 5);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_AUTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_TAXA)
                .HasPrecision(6, 5);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_ANTECIPACAO>()
                .Property(e => e.ANTEC_AUTO_TAXA)
                .HasPrecision(6, 5);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ULTIMA_ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ULTIMO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.PRIMEIRO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.PRIMEIRA_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_PARCEIRO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.TIPO_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_SIMULACAO_EFETIVADA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.TERMO_ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CABECALHO>()
                .Property(e => e.ID_CNPJ_TAXAS_PREAPROVADAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.SUBRAMO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.CEP_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_FRANQUIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FILIAIS_FRANQUIAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.CONQUISTA_RETENCAO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TEMPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.VOLUME_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.VOLUME_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CRED_V_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_DEB_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_2_6_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_7_12_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CARNE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_RECORRENTE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CRED_V_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_DEB_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_2_6_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PARC_7_12_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CARNE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_RECORRENTE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_LIQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.SHARE_NEG)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_MASTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_FAT_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CRED_V)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_PARC_2_6)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_PARC_7_12)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CARNE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_PLAT_BLA_GOLD_CORP)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_CLASS_INTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_REBATE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_REBATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_MINIMO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PORC_PATROCINIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_PATROCINIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_VOLUME)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ANTEC_TAXA_AM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OI_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OI_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_CLARO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_CLARO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_TIM_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_TIM_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_VIVO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_VIVO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OUTROS_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.REC_OUTROS_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_CORTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PRAZO_PAGAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_ANTIFRAUDE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_GATEWAY_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_CONCILIDAOR_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_FAT_COFRE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_NUM_TRANS_CONC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_VOLUME_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PD_TICKET_MEDIO_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_TERMO_OBRIGATORIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_EVIDENCIA_VALIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NOME_CONCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CREDIARIO_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_CREDIARIO_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TM_CREDIARIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.NOME_CRIADOR)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.TAXA_SERVICO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.DIAS_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.IND_PRECIFICACION_DINAMICA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FREQ_FAT_GETNET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PRZLIQ_CRED_V_PRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.PRZLIQ_CRE_V_ECOM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.ID_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.C3ds)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FATURAMENTO_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_CLIENTE>()
                .Property(e => e.FAT_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_DEFESA>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_DEFESA>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_DEFESA>()
                .Property(e => e.ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_DEFESA>()
                .Property(e => e.DEFESA_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_DEFESA>()
                .Property(e => e.TEXTO_MESA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_GRUPO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_GRUPO>()
                .Property(e => e.CNPJ_MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_GRUPO>()
                .Property(e => e.CNPJ_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_GRUPO>()
                .Property(e => e.ADICIONAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.MDR_LIQUIDA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.BAI)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.MOL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.ID_FORMULA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_MDR>()
                .Property(e => e.VALOR_FORMULA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.ID_PLASTICO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.PERC_PLASTICO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<SOLICITACOES_PLASTICOS>()
                .Property(e => e.PERC_REF)
                .HasPrecision(6, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ID_DIM_REPREC_EVENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.AMEX_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ELO_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.HIPER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_VISA_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_MASTER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_ELO_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_AMEX_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_CREDITO_A_VISTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ECOM_HIPER_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_REPREC>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SUBSIDIO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SUBSIDIO>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SUBSIDIO>()
                .Property(e => e.PCT_SUBSIDIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_SUBSIDIO>()
                .Property(e => e.DESC_SUBSIDIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.ID_DIM_SVA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.TRANSACOES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.CUSTO)
                .HasPrecision(20, 4);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.RECEITA_BRUTA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.RECEITA_LIQUIDA)
                .HasPrecision(20, 4);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SODEXO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_ALELO_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_VR_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BEN_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKET_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_TICKETLOG_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_BANESTES_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_SOROCRED_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_RECEITA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_SVA>()
                .Property(e => e.VOUCHER_GOODCARD_CUSTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.COD_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.IND_ECOMMERCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.IND_ECOMMERCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TAXAS_SEM_DESC>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.COD_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.NUMERO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.VALOR_ALUGUEL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.GMUD)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.TASK_JIRA)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.TIPO_TASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .HasMany(e => e.SURVEY_CONTROLE_VISUALIZACAO)
                .WithRequired(e => e.SURVEY_CABECALHO)
                .HasForeignKey(e => e.ID_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .HasMany(e => e.SURVEY_QUESTOES)
                .WithRequired(e => e.SURVEY_CABECALHO)
                .HasForeignKey(e => e.ID_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_CABECALHO>()
                .HasMany(e => e.SURVEY_RESPOSTAS_USUARIO)
                .WithRequired(e => e.SURVEY_CABECALHO)
                .HasForeignKey(e => e.ID_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_CONTROLE_VISUALIZACAO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_CONTROLE_VISUALIZACAO>()
                .Property(e => e.ID_CABECALHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_CONTROLE_VISUALIZACAO>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_QUESTOES>()
                .Property(e => e.ID_QUESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_QUESTOES>()
                .Property(e => e.ID_CABECALHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_QUESTOES>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SURVEY_QUESTOES>()
                .HasMany(e => e.SURVEY_RESPOSTAS)
                .WithRequired(e => e.SURVEY_QUESTOES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_QUESTOES>()
                .HasMany(e => e.SURVEY_RESPOSTAS_USUARIO)
                .WithRequired(e => e.SURVEY_QUESTOES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_RESPOSTAS>()
                .Property(e => e.ID_RESPOSTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS>()
                .Property(e => e.ID_QUESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS>()
                .HasMany(e => e.SURVEY_RESPOSTAS_USUARIO)
                .WithRequired(e => e.SURVEY_RESPOSTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SURVEY_RESPOSTAS_USUARIO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS_USUARIO>()
                .Property(e => e.ID_CABECALHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS_USUARIO>()
                .Property(e => e.ID_QUESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS_USUARIO>()
                .Property(e => e.ID_RESPOSTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SURVEY_RESPOSTAS_USUARIO>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAANTECIPACAO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAANTECIPACAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAANTECIPACAO>()
                .Property(e => e.ATIVA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAANTECIPACAO>()
                .HasMany(e => e.ANTECIPACAOSEGM)
                .WithRequired(e => e.TAXAANTECIPACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>()
                .Property(e => e.CAMINHO_ARQUIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>()
                .Property(e => e.PROCESSANDO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>()
                .Property(e => e.NUMERO_TENTATIVAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO>()
                .Property(e => e.ID_TAXAS_PREAPROVADAS_UPLOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_NIVEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_NIVEL>()
                .Property(e => e.NIVEL)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_NIVEL>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_NIVEL>()
                .Property(e => e.PRIORIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_NIVEL>()
                .HasMany(e => e.TAXAS_PREAPROVADAS_REJEITADAS)
                .WithRequired(e => e.TAXAS_PREAPROVADAS_NIVEL)
                .HasForeignKey(e => e.NIVELID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_REJEITADAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_REJEITADAS>()
                .Property(e => e.UPLOADID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_REJEITADAS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_REJEITADAS>()
                .Property(e => e.NIVELID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_REJEITADAS>()
                .Property(e => e.CAUSA)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .Property(e => e.USUARIOSOL)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .Property(e => e.ARQUIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .Property(e => e.TIPOUPLOAD)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .HasMany(e => e.TAXAS_PREAPROVADAS_FILA_PROCESSAMENTO)
                .WithRequired(e => e.TAXAS_PREAPROVADAS_UPLOAD)
                .HasForeignKey(e => e.ID_TAXAS_PREAPROVADAS_UPLOAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .HasMany(e => e.TAXAS_PREAPROVADAS_REJEITADAS)
                .WithRequired(e => e.TAXAS_PREAPROVADAS_UPLOAD)
                .HasForeignKey(e => e.UPLOADID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD>()
                .HasMany(e => e.TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO)
                .WithRequired(e => e.TAXAS_PREAPROVADAS_UPLOAD)
                .HasForeignKey(e => e.ID_TAXAS_PREAPROVADAS_UPLOAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO>()
                .Property(e => e.DESCRICAO_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_LOG_ERRO>()
                .Property(e => e.ID_TAXAS_PREAPROVADAS_UPLOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_STATUS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TAXAS_PREAPROVADAS_UPLOAD_STATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOANTECIPACAO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TIPOANTECIPACAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOANTECIPACAO>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TIPOANTECIPACAO>()
                .HasMany(e => e.ANTECIPACAOSEGM)
                .WithRequired(e => e.TIPOANTECIPACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TMP_BASE>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.MATRICULA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USUARIOS_PRICING>()
                .Property(e => e.RELATORIOS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.CNAE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CNAE_RESULTADO>()
                .Property(e => e.ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_TECNOLOGIAS>()
                .Property(e => e.ID)
                .HasPrecision(1, 1);

            modelBuilder.Entity<DIM_TECNOLOGIAS>()
                .Property(e => e.COD_TIPO_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_TECNOLOGIAS>()
                .Property(e => e.COD_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DIM_TECNOLOGIAS>()
                .Property(e => e.TIPO_TECNOLOGIA)
                .IsUnicode(false);

            modelBuilder.Entity<DIM_TECNOLOGIAS>()
                .Property(e => e.ALUGUEL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.SEGMENTO_RH)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.COD_REDE)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.REDE)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.UNIORG_REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.COD_NUCLEO)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.NUCLEO)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<HIERARQUIA_COMERCIAIS_GETNET>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMS_GESTAO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMS_GESTAO>()
                .Property(e => e.COD_TIPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMS_GESTAO>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARM_HISTORICAS>()
                .Property(e => e.DIAS_TRANSACIONAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARM_HISTORICAS>()
                .Property(e => e.STATUS_HISTORICA)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.MDR_PONDERADA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CRED_V)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.BANDEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ANTECIPACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CRED_V_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_DEBITO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_PARC_2_6_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_PARC_7_12_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CARNE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_RECORRENTE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TAXA_MIN_CREDIARIO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ANTEC_PONTUAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ANTEC_PONTUAL_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.TIPO_RECEB)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.SUBSIDIO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.DIST_PERC_FISICO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.DIST_PERC_ECOMM)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.POS_GPRS_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.PINDPAD_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.CONECTIVIDADE_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.SGET_ALUG_SEM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.SGET_ALUG_COM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.CHECKOUT_MOVEL_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ECOMM_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.ANTEC_AUTO_PERC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.PRAZO_CONTRATO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.DESCONTO_MAX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_ALCADA_IMPORTA>()
                .Property(e => e.CODIGO_CAMPANHA)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.COD_TIPO_SERVICO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.COD_SERVICO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.NOME_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.VALUE)
                .HasPrecision(25, 20);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.VOLUME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SERVICOS_ADICIONAIS>()
                .Property(e => e.ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_BANDEIRAS>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_BANDEIRAS>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_SOLICITACOES_FATURAMENTOS>()
                .Property(e => e.COD_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_FATURAMENTOS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_FATURAMENTOS>()
                .Property(e => e.PCT_FATURAMENTO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_SOLICITACOES_PLATINIZACAO>()
                .Property(e => e.IDBANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_PLATINIZACAO>()
                .Property(e => e.IDPLASTICO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_PLATINIZACAO>()
                .Property(e => e.IDMODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_PLATINIZACAO>()
                .Property(e => e.PERCREF)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_SOLICITACOES_TAXASAPROV>()
                .Property(e => e.COD_TIPO_TAXA)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_SOLICITACOES_TAXASAPROV>()
                .Property(e => e.IND_ECOMMERCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TAXASAPROV>()
                .Property(e => e.COD_BANDEIRA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TAXASAPROV>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TAXASAPROV>()
                .Property(e => e.TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.COD_TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.NUMERO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TECNOLOGIAS>()
                .Property(e => e.VALOR_ALUGUEL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_SOLICITACOES_TICKETS>()
                .Property(e => e.COD_MODALIDADE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_SOLICITACOES_TICKETS>()
                .Property(e => e.TICKET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.FATURAMENTO_MIN)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.FATURAMENTO_MAX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.MDR_PONDERADA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CRED_V)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_PARC_2_6)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_PARC_7_12)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_DEBITO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CARNE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_RECORRENTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CREDIARIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.BANDEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ANTECIPACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CRED_V_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_DEBITO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_PARC_2_6_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_PARC_7_12_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CARNE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_RECORRENTE_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TAXA_MIN_CREDIARIO_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ANTEC_PONTUAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ANTEC_PONTUAL_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.TIPO_RECEB)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.SUBSIDIO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.DIST_PERC_FISICO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.DIST_PERC_ECOMM)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.POS_GPRS_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.PINDPAD_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.CONECTIVIDADE_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.SGET_ALUG_SEM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.SGET_ALUG_COM_BOBINA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.CHECKOUT_MOVEL_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ECOMM_QTD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEALCADA_TEMPTABLE>()
                .Property(e => e.ANTEC_AUTO_PERC)
                .HasPrecision(6, 4);

            modelBuilder.Entity<TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEBASECNPJBLINDADO_TEMPTABLE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEPARAMSGESTAO_TEMPTABLE>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATEPARAMSGESTAO_TEMPTABLE>()
                .Property(e => e.PCT_FAT_REAL)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEPARAMSGESTAO_TEMPTABLE>()
                .Property(e => e.AUMENTO_TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATEPARAMSGESTAO_TEMPTABLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TMP_UPDATETAXAS_TEMPTABLE>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_UPDATETAXAS_TEMPTABLE>()
                .Property(e => e.PCT_FAT_REAL)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATETAXAS_TEMPTABLE>()
                .Property(e => e.AUMENTO_TAXA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TMP_UPDATETAXAS_TEMPTABLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<VW_ALERTAS_ATENDIMENTO>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ULTIMA_ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ULTIMO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.PRIMEIRO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.PRIMEIRA_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_PARCEIRO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.TIPO_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_SIMULACAO_EFETIVADA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.TERMO_ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_CNPJ_TAXAS_PREAPROVADAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.ID_SEGMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_HIST>()
                .Property(e => e.DESC_PARCEIRO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_ESTADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ULTIMA_ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ULTIMO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.PRIMEIRO_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.PRIMEIRA_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.IDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_PARCEIRO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.TIPO_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_SIMULACAO_EFETIVADA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.TERMO_ATIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_COMBO_PROM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_CNPJ_TAXAS_PREAPROVADAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.ID_SEGMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CABECALHO_TRANS>()
                .Property(e => e.DESC_PARCEIRO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.SUBRAMO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.CEP_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.IND_FRANQUIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FILIAIS_FRANQUIAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.CONQUISTA_RETENCAO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TEMPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.VOLUME_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.VOLUME_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CRED_V_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_DEB_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PARC_2_6_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PARC_7_12_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CARNE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_RECORRENTE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CRED_V_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_DEB_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PARC_2_6_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PARC_7_12_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CARNE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_RECORRENTE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PRAZO_LIQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.SHARE_NEG)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_MASTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_FAT_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_CRED_V)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_PARC_2_6)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_PARC_7_12)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_CARNE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_PLAT_BLA_GOLD_CORP)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_CLASS_INTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_REBATE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_REBATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_MINIMO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PORC_PATROCINIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_PATROCINIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ANTEC_VOLUME)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ANTEC_PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ANTEC_TAXA_AM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_OI_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_OI_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_CLARO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_CLARO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_TIM_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_TIM_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_VIVO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_VIVO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_OUTROS_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.REC_OUTROS_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PRAZO_CORTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PRAZO_PAGAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_FAT_ANTIFRAUDE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_FAT_GATEWAY_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_FAT_CONCILIDAOR_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_FAT_COFRE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_NUM_TRANS_CONC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_VOLUME_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PD_TICKET_MEDIO_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.IND_TERMO_OBRIGATORIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.IND_EVIDENCIA_VALIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NOME_CONCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CREDIARIO_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_CREDIARIO_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TM_CREDIARIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.NOME_CRIADOR)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.TAXA_SERVICO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.DIAS_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.IND_PRECIFICACION_DINAMICA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FREQ_FAT_GETNET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PRZLIQ_CRED_V_PRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.PRZLIQ_CRE_V_ECOM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.ID_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.C3ds)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FATURAMENTO_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_HIST>()
                .Property(e => e.FAT_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REGIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ORDEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.SUBRAMO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.CEP_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.IND_FRANQUIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FILIAIS_FRANQUIAS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.CONQUISTA_RETENCAO)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TEMPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FATURAMENTO)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.VOLUME_PRES)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.VOLUME_ECOM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CRED_V_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_DEB_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PARC_2_6_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PARC_7_12_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CARNE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_RECORRENTE_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CRED_V_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_DEB_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PARC_2_6_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PARC_7_12_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CARNE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_RECORRENTE_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PRAZO_LIQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.SHARE_NEG)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_VISA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_MASTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_ELO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_AMEX)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_HIPER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_FAT_HIPERCARD)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_CRED_V)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_DEB)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_PARC_2_6)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_PARC_7_12)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_CARNE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_PLAT_BLA_GOLD_CORP)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_CLASS_INTER)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_REBATE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_REBATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_MINIMO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PORC_PATROCINIO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_PATROCINIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ANTEC_VOLUME)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ANTEC_PRAZO_MEDIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ANTEC_PORC_CDI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ANTEC_TAXA_AM)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_OI_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_OI_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_CLARO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_CLARO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_TIM_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_TIM_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_VIVO_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_VIVO_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_OUTROS_FAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.REC_OUTROS_COM_CLI)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PRAZO_CORTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PRAZO_PAGAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_FAT_ANTIFRAUDE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_FAT_GATEWAY_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_FAT_CONCILIDAOR_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_FAT_COFRE_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_RECORRENTE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_NUM_TRANS_CONC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_VOLUME_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PD_TICKET_MEDIO_CONC)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.IND_TERMO_OBRIGATORIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.IND_EVIDENCIA_VALIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NOME_CONCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CREDIARIO_PRES)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_CREDIARIO_ECOM)
                .HasPrecision(20, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TM_CREDIARIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.NOME_CRIADOR)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.TAXA_SERVICO)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.DIAS_RECEBA_JA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.MULTA)
                .HasPrecision(5, 4);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.IND_PRECIFICACION_DINAMICA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FREQ_FAT_GETNET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PRZLIQ_CRED_V_PRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.PRZLIQ_CRE_V_ECOM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.ID_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.C3ds)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FATURAMENTO_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICITACOES_CLIENTE_TRANS>()
                .Property(e => e.FAT_GETNET)
                .HasPrecision(12, 2);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_SUPERGET_ALU_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_SUPERGET_ALU_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_SUPERGET_ALU_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_SUPERGET_ALU_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_CHECKOUT_MOVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.ALU_CHECKOUT_MOVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_SUPERGET_VENDA_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_1>()
                .Property(e => e.NUM_SUPERGET_VENDA_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_POS_DIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_POS_GPRS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_POS_BANDA_LARGA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_POS_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_PINPADS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_CONECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_MAIS_GESTAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_MINHA_LOJA_DIGITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_SUPERGET_ALU_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_SUPERGET_ALU_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_SUPERGET_ALU_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_SUPERGET_ALU_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_CHECKOUT_MOVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.ALU_CHECKOUT_MOVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_SUPERGET_VENDA_SEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLICTECNOLOGIAS_2>()
                .Property(e => e.NUM_SUPERGET_VENDA_COM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLTAXA_APROV_MAX>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLTAXA_APROV_MAX>()
                .Property(e => e.MAX_TAXA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLTAXA_CONC_MAX>()
                .Property(e => e.ID_SOLICITACAO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VW_SOLTAXA_CONC_MAX>()
                .Property(e => e.MAX_TAXA)
                .HasPrecision(38, 0);
        }
    }
}

using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationMarketsApi.Settings
{
    public class SettingsModel
    {
        [YamlProperty("EducationMarketsApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("EducationMarketsApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("EducationMarketsApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("EducationMarketsApi.EnableApiTrace")]
        public bool EnableApiTrace { get; set; }

        [YamlProperty("EducationMarketsApi.MyNoSqlReaderHostPort")]
        public string MyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationMarketsApi.AuthMyNoSqlReaderHostPort")]
        public string AuthMyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationMarketsApi.SessionEncryptionKeyId")]
        public string SessionEncryptionKeyId { get; set; }

        [YamlProperty("EducationMarketsApi.MyNoSqlWriterUrl")]
        public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationMarketsApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
    }
}

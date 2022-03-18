using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationMarketsApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationMarketsApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationMarketsApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationMarketsApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationMarketsApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationMarketsApi.Controllers.Contracts
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}
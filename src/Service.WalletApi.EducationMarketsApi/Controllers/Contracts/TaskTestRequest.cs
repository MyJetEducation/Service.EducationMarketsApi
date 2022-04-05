using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationMarketsApi.Controllers.Contracts
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}
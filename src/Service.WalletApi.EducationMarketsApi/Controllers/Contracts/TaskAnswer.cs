using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationMarketsApi.Controllers.Contracts
{
	public class TaskAnswer
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public int[] Value { get; set; }
	}
}
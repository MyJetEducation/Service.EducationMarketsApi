using System.ComponentModel.DataAnnotations;

namespace Service.EducationMarketsApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}
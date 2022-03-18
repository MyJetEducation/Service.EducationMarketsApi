using System.ComponentModel.DataAnnotations;

namespace Service.EducationMarketsApi.Models
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}
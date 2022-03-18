﻿using System.ComponentModel.DataAnnotations;

namespace Service.EducationMarketsApi.Models
{
	public class TaskTrueFalse
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public bool Value { get; set; }
	}
}
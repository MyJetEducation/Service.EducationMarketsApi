﻿using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationMarketsApi.Controllers.Contracts
{
	public class TaskTrueFalse
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public bool Value { get; set; }
	}
}
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_MSSQL_API.Models
{
	public class ArticleModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }

		public ICollection<PriceModel> Prices { get; set; }
	}
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_MSSQL_API.Models
{
	public class PriceModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public decimal Price { get; set; }

		[Required]
		public DateTime Date { get; set; }

		public int ArticleId { get; set; }

		[ForeignKey("ArticleId")]
		public ArticleModel Article { get; set; }
	}
}
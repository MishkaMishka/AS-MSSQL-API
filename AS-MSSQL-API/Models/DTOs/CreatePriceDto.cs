using System.ComponentModel.DataAnnotations;

namespace AS_MSSQL_API.Models.DTOs
{
	public class CreatePriceDto
	{
		[Required]
		public decimal Price { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}

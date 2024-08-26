using System.ComponentModel.DataAnnotations;

namespace AS_MSSQL_API.Models.DTOs
{
	public class CreateArticleDto
	{
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }

		public List<CreatePriceDto> Prices { get; set; }
	}
}

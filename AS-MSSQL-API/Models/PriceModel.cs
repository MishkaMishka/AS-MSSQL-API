using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AS_MSSQL_API.Models
{
	public class PriceModel
	{
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public float Price { get; set; }

        public DateTime Date { get; set; }
    }
}
using System;
namespace Demo
{
	public class Order
	{
		public Order()
		{
		}

		public int Id { get; set; }
		public string Account { get; set; }
		public string Item { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public DateTime OrderDate { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInternal
{
	public class GoldCustomer : Customer
	{
		public void OfferVoucher()
		{
			var rating = this.CalculateRating(true);

			if (rating == 0)
			{
				Console.WriteLine("Voucher Offered");
			}
			else
			{
				Console.WriteLine("Voucher is not currently available");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var goldCustomer = new GoldCustomer();
			goldCustomer.OfferVoucher();
		}
	}
}

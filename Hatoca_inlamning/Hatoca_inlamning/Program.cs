using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hatoca_inlamning
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			Application app = new Application();
			//Application.Run(app);
		}
		/*using (var db = new BookingContext())
		{
			Console.Write("Enter a name for a customer: ");
			var cname = Console.ReadLine();

			var customer = new Customer { cname = cname };
			db.Customers.Add(customer);
			db.SaveChanges();

			var query = from b in db.Customers
						orderby b.cname
						select b;

			Console.WriteLine(" All customers in the database:");
			foreach (var item in query)
			{ Console.WriteLine(item.cname); }
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();*/
	}

		}

	//}


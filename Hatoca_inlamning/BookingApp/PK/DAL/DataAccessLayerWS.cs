using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking;

namespace BookingApp.PK.DAL
{
	class DataAccessLayerWS
	{

		
		Booking.WebServiceRef.WebServiceSoapClient client = new Booking.WebServiceRef.WebServiceSoapClient();
		public string GetFileContent(string filename)
		{
			try
			{
				return client.GetFileContent(filename);
			}
			catch (Exception ex)
			{
				throw new Exception();
			}
		}
	}
}

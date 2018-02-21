using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.PK.DAL
{
	class DataAccessLayerWS
	{


		ServiceReference.CSharpWebServiceSoapClient client = new ServiceReference.CSharpWebServiceSoapClient();
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

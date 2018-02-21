using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.PK.Controller
{
	class ControllerWS
	{

		DAL.DataAccessLayerWS dal = new DAL.DataAccessLayerWS();

		public string GetFileContent(string filename)
		{
			return dal.GetFileContent(filename);
		}
	}
}
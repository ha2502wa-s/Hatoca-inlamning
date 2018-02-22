using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp
{
	public class Controller
	{
		private DataAccessLayer dal = new DataAccessLayer();

		public Controller()
		{ }

		/*public List<Gymsession> GetAllGymsessions()
		{
			return dal.GetAllGymsessions();
		}*/
	}
}
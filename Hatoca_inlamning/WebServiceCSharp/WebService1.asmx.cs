using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WebServiceCSharp
{

	[WebService(Namespace = "http://hatoca.lu.se")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]

	public class WebService1 : System.Web.Services.WebService
	{

		[WebMethod]
		public string GetFileContent(string filename)
		{
			if (filename != null)
			{
				StreamReader streamReader = new StreamReader(filename);
				string text = streamReader.ReadToEnd();
				streamReader.Close();

				return text;
			}
			return null;
		}
	}
}

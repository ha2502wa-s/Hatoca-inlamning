using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp
{
	public class ErrorException
	{
		public ErrorException() { }
		public string errorMessage { get; set; }

		public ErrorException(string message)
		{
			errorMessage = message;

		}
	}
}
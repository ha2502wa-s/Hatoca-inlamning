using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WebServiceApp
{

	[WebService(Namespace = "http://hatoca.lu.se")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]

	public class WebService : System.Web.Services.WebService
	{
		/*
		public class Gymsession
		{
			private string gid;

			public string Gid
			{
				get { return gid; }
				set { gid = value; }
			}

			public Gymsession() { }

			public Gymsession(global::Gymsession gymsession)
			{
				Gid = gymsession.gid;
			}
		}

		public class Customer
		{
			private String cpnr;

			public String Cpnr
			{
				get { return cpnr; }
				set { cpnr = value; }
			}

			public Customer() { }

			public Customer(global::Customer customer)
			{
				Cpnr = customer.cpnr;
			}
		}*/

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
		/*
		[WebMethod]
		public List<Gymsession> GetAllGymsessions()
		{
			List<Gymsession> gymsessions = new List<Gymsession>();


			foreach (global::Gymsession gymsessions in controller.GetAllGymsessions())
			{
				Gymsession newGymsession = new Gymsession(gymsession);
				gymsessions.Add(newGymsession);
			}

			return apartments;

		}

		[WebMethod]
		public List<Customer> GetAllCustomers()
		{
		List<Customer> customers = new List<Customers>();

		foreach (global::Customer customers in controller.GetAllCustomers())
		{
		Customer newCustomer = new Customer(customer);
		customers.Add(newCustomer);
		}
		return customers;
		}

		*/

	}
}

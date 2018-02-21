 using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingApp.PK.DAL;

namespace BookingApp.PK.Controller
{
    class Controller
    {
        DALtest dal = new DALtest();

        public string AddCustomer(string cpnr, string cname, string caddress, string ctel, string cmail)
        {
            return dal.AddCustomer(cpnr, cname, caddress, ctel, cmail);
        }
    
        /*
		public void AddCustomer(string cpnr)
        { dal.AddCustomer(cpnr);}

		public void DeleteGymsession(string gid)
		{ dal.DeleteGymsession(gid); }

		public void DeleteCustomer(string cpnr)
		{ dal.DeleteCustomer(cpnr); }

		public void SearchGymsession(string gid, string gtitle)
		{ dal.SearchGymsession(gid, gtitle); }

		public void SearchCustomer(string cpnr, string cname)
		{ dal.SearchCustomer(cpnr, cname); }

		public void ShowGymsessions()
		{ dal.ShowGymsessions(); } // KOLLA PÅ DENNA

		public void AddBooking(string cpnr, string gid)
		{ dal.AddBooking(cpnr, gid); }

		public void CancelReservation(string cpnr, string gid)
		{ dal.CancelReservation(cpnr, gid); }
		public Customer GetCustomer(string cpnr)
        {return dal.GetCustomer(cpnr); }
       
        public Gymsession GetGymsession(string gid)
        {return dal.GetGymsession(gid);}

		public void DeleteBooking(string cpnr, string gid)
        { dal.DeleteBook(cpnr, gid); }

		public void GetAllForCustomer(string cpnr)
		{ dal.GetAllForCustomer(cpnr); }*/

        

	}
}

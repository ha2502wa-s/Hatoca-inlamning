using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking;

namespace BookingApp.PK.DAL
{
    class DALtest
    {

        /*BookingAppContext bd = new BookingAppContext();
        string message;
        public string AddCustomer(string cpnr, string cname, string caddress, string ctel, string cmail)
        {
            Customer c = new Customer();
            try
            {
              List<Customer> customerlist = bd.Customers.Where(r => r.cpnr == cpnr).ToList();

                if (customerlist.Count() == 0)
                {
                    bd.Customers.Add(new Customer());
                    bd.SaveChanges();
                    message = "kunden är tillagd";
                    return message;
                }
            }
            catch (InvalidOperationException)
            {
                bd.Customers.Remove(c);
                throw new Exception("Databasfel, kontakta systemadminstratör!");
            }

            message = "Meddelande: Kunden kunde inte bli tillagd då kunden med det personnummert redan existerar!";
            return message;
        }
    }
    public void AddGymsession(string gid, string gtitle, string gdate, string gmax_spots, string ginstructor)
        {
                bd.Gymsessions.Add(new Gymsession());
                bd.SaveChanges(); *
        }
    public void DeleteGymsession(string gid)
        {
         bd.Gymsessions.Remove(Gymsession);
         bd.SaveChanges();
        }

 public void DeleteCustomer(string cpnr)
 {
         bd.Customers.Remove(Customer);
         bd.SaveChanges();
 }
 public void SearchGymsession(string gid, string gtitle)

    -------------------

    public List<Gymsession> GetAllGymsessions()
    {
     try
        {
         List<Gymsession> GymsessionList = bd.Gymsessions.ToList();

         if (apartmentList.Count == 0)
         {
             return null;
         }

         return apartmentList;
     }
     catch (InvalidOperationException)
     {
         throw new DatabaseException("Databasfel, kontakta systemadminstratör");
     }
 }

     public void ShowGymsessions()
     { dal.ShowGymsessions(); } 

     public string AddBooking(string cpnr, string gid)
     {  }

     public void CancelReservation(string cpnr, string gid)
     { dal.CancelReservation(cpnr, gid); }

     public Customer GetCustomer(string cpnr)
     { return dal.GetCustomer(cpnr); }

     public Gymsession GetGymsession(string gid)
     { return dal.GetGymsession(gid); }

     public void DeleteBooking(string cpnr, string gid)
     { dal.DeleteBook(cpnr, gid); }

     public void GetAllForCustomer(string cpnr)
     { dal.GetAllForCustomer(cpnr); } */

    }
}




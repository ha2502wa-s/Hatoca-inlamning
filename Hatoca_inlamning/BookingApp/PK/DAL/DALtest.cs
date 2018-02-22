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

      /* BookingAppContext bd = new BookingAppContext();
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
   
        public string AddGymsession(string gid, string gtitle, string gdate, string gmax_spots, string ginstructor)
        {
            Gymsession g = new Gymsesssion();
            try
            {
            List<Gymsession> Gymsessionlist = bd.Gymsessions.Where(r => r.gid == gid).ToList();

            if (Gymsessionlist.Count() == 0)
            {
                bd.Gymsessions.Add(new Gymsession());
                bd.SaveChanges();
                message = "The gymsession is added";
                return message;
            }
        }
        catch (InvalidOperationException)
        {
            bd.Gymsession.Remove(g);
            throw new Exception("Databasfel, kontakta systemadminstratör!");
        }

        message = "Meddelande: Träningspasset kunde inte bli tillagd då träningspasset med det id:et redan existerar!";
        return message;
        }
         public void DeleteGymsession(string gid)
        {
            try
            {
                List<Gymsession> gymsessionList = bd.Gymsessions.Where(r => r.gid == gid).ToList();

                if (gymsessionList.Count() != 0)
                {
                    Apartment a = con.Apartment.First(r => r.apartmentNr == apartmentNr);
                    con.Apartment.Remove(a);
                    con.SaveChanges();
                    return message = "Meddelande: Lägenhet borttagen!";
                }
            }
            catch (InvalidOperationException)
            {
                throw new DatabaseException("Databasfel, kontakta systemadminstratör!");
            }
            message = "Meddelande: Borttagning misslyckades, lägenheten finns inte!";
            return message;

        }

 public void DeleteCustomer(string cpnr)
 {
        try
        {
            List<Gymsession> gymsessionList = bd.Gymsessions.Where(r => r.gid == gid).ToList();

            if (gymsessionList.Count() != 0)
            {
                Apartment a = con.Apartment.First(r => r.apartmentNr == apartmentNr);
                con.Apartment.Remove(a);
                con.SaveChanges();
                return message = "Meddelande: Lägenhet borttagen!";
            }
        }
        catch (InvalidOperationException)
        {
            throw new DatabaseException("Databasfel, kontakta systemadminstratör!");
        }
        message = "Meddelande: Borttagning misslyckades, lägenheten finns inte!";
        return message;
    }
    
 public void SearchGymsession(string gid, string gtitle)
    { }
    -------------------

    public List<Gymsession> GetAllGymsessions()
    {
     try
        { List<Gymsession> gymsessionList = bd.Gymsessions.ToList();
         if (gymsessionList.Count == 0)
         {
             return null;
         }

         return gymsessionList;
     }
     catch (InvalidOperationException)
     {
         throw new Exception("Databasfel, kontakta systemadminstratör");
     }

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
     { dal.GetAllForCustomer(cpnr); }*/

    }
}




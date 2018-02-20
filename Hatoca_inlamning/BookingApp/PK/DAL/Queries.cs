using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.PK.DAL
{
    class Queries
    {
        public String GetCustomer()
        {
            return "SELECT * FROM Customer WHERE cpnr = ? ";
        }

        public String GetCustomerToTable()
        {
            return "SELECT cpnr AS 'Customer pnr' UPPER (cname) AS 'Name', " + "UPPER(caddress) AS 'Address' FROM Customer WHERE cpnr = ?";
        }

        public String GetGymsession()
        {
            return "SELECT * FROM Gymsession WHERE gid = ?";
        }

        public String GetInstructor()
        {
            return "SELECT * FROM Instructor WHERE iid = ?";
        }

        public String AddCustomer()
        {
            return "INSERT INTO Customer VALUES (?,?,?,?,?)";
        }

        public String AddGymsession()
        {
            return "INSERT INTO Gymsession VALUES (?,?,?,?,?)";
        }

        public String DeleteGymsession()
        {
            return "DELETE FROM Gymsession WHERE gid = ?";
        }
        public String DeleteCustomer()
        {
            return "DELETE FROM Customer WHERE cpnr = ?";
        }
        public String BookSession()
        {
            return "INSERT INTO book VALUES (?,?)";
        }
        public String AllSessions()
        {
            return "SELECT UPPER (gid) AS Session ID, UPPER (gTitle) AS Title, UPPER (gPlace) AS Place, UPPER (gTime) AS Time, UPPER (gmax_spots) as Spots FROM Session";
        }
    }
}

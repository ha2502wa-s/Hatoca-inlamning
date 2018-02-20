using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using System.Data.SqlClient.SQLException;


namespace BookingApp.PK.DAL
{

    class DataAccessLayer
    {
        /* public void AddGymsession(Gymsession gymsession) throws SQLException 
         {
             String sql = "INSERT INTO Gymsession VALUES (?,?,?,?,?)";

                 try (Connection con = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = con.prepareStatement(sql);) {
                     pStmt.setString(1, gymsession.getGid());
                     pStmt.setString(2, gymsession.getGtitle());
                     pStmt.setString(3, gymsession.getGdate());
                     pStmt.setString(4, gymsession.getGmax_spots());
                     pStmt.setString(5, gymsession.Ginstructor());

                 return pStmt.executeUpdate();
             } catch (SqlException s)
             { MessageBox.Show("Gymsession could not be added"); 
             }

         }

         public void AddCustomer(Customer customer) throws SQLException
         {
             String sql = "INSERT INTO Customer VALUES (?,?,?,?,?)";

                 try (Connection con = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = con.prepareStatement(sql);) {
                     pStmt.setString(1, customer.getCpnr());
                     pStmt.setString(2, customer.getCname());
                     pStmt.setString(3, customer.getCaddress());
                     pStmt.setString(4, customer.getCtel());
                     pStmt.setString(5, customer.GetCmail());

                return pStmt.executeUpdate();
             } catch (SqlException s)
             { MessageBox.Show("Customer could not be added");
             }
         }

         public void DeleteGymsession(String gid) throws Exception

         {
             String sql = "DELETE FROM Gymsession WHERE gid =?";

               try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
                     pStmt.setString(1, gid);

              return pStmt.executeUpdate();
             } catch (SQLException s)
             { MessageBox.Show("Gymsession could not be deleted");
             }
         }

         public void DeleteCustomer(String cpnr) throws Exception
         {
             String sql = "DELETE FROM Customer WHERE cpnr =?";

             try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
                   pStmt.setString(1, cpnr);

         return pStmt.executeUpdate(); }

         catch (SqlException) {
             MessageBox.Show("Customer could not be deleted");
         }
         }

 public void Arraylist<Gymsession> SearchGymsessions(String search) throws Exception
         {
           String sql = "SELECT * FROM " + Gymsession + " WHERE " + gid + " LIKE ? OR " gtitle " LIKE ?"
         try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
         pStmt.setString(1, search + "%");
         pStmt.setString(2, search + "%");
         ArrayList<Gymsession> gymsessions = this.mapResultSetToStudents(pStmt.executeQuery()); 

         return gymsessions;

     } catch (SQLException e)
     {
         throw new DBException("Sökning misslyckades för " + search);
     }
 }

         public void ArrayList<Customer> SearchCustomer(string search) throws Exception
     {
         String sql = "SELECT * FROM " + Customer + " WHERE " + cpnr + " LIKE ? OR " cname " LIKE ?"
         try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
             pStmt.setString(1, search + "%");
             pStmt.setString(2, search + "%");
             ArrayList<Customer> customers = this.mapResultSetToStudents(pStmt.executeQuery()); //lista på sessions

             return customers;

         } catch (SQLException e)
         {
             throw new DBException("Sökning misslyckades för " + search);
         }
     }

         public void ShowCustomers()
        {
           String sql = "SELECT * FROM Gymsession";
           try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);)
         }

         public void AddBooking()
         {
     String sql = "INSERT INTO " + TABLE + " VALUES (?, ?, ?)";

     try (Connection conn = MsSqlConnectionFactory.getConnection();
     PreparedStatement pStmt = conn.prepareStatement(sql);) {
         pStmt.setString(1, studies.getPnr());
         pStmt.setString(2, studies.getCourseCode());
         pStmt.setString(3, studies.getTerm());

         return pStmt.executeUpdate() > 0;
     }

         public void CancelReservation()
         {
     String sql = "DELETE FROM " + Booking + " WHERE " + cpnr + " = ? AND " + gid + " = ?";

     try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
         pStmt.setString(1, Booking.getCpnr());
         pStmt.setString(2, Booking.getGid ());

         return pStmt.executeUpdate() > 0;
     } catch (SQLException e) { }


       public ArrayList<Booking> getAllForCustomer(String cpnr) throws DBException {

       String sql = "SELECT * FROM Booking WHERE cpnr = ?";

       try (Connection conn = MsSqlConnectionFactory.getConnection(); PreparedStatement pStmt = conn.prepareStatement(sql);) {
           pStmt.setString(1, cpnr);
           ArrayList<Booking> booking = this.mapResultSetToBooking(pStmt.executeQuery());

           return booking;
         } catch (SQLException e)
         {
           throw new DBException(
                   "sökningen misslyckades");
         }
   }

}
   } */

    }
}

using library_support_system.Model;
using library_support_system.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace library_support_system.Repositories
{
    internal class RentalRepository : IDisposable
    {
        private readonly OracleConnection _conn;

        public RentalRepository()
        {
            string connStr = "Data Source=(...);User Id=...;Password=...;"; // 실제 정보로 교체
            _conn = new OracleConnection(connStr);
            _conn.Open();
        }

        // CREATE: 대여 기록 추가
        public bool Create(RentalModel rental)
        {
            using (var cmd = _conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO Rentals
                    (Rental_Seq, Book_ISBN, User_Phone, Rental_Status, Rental_Date, Rental_Return_Date)
                    VALUES
                    (:Rental_Seq, :Book_ISBN, :User_Phone, :Rental_Status, :Rental_Date, :Rental_Return_Date)";
                cmd.Parameters.Add(new OracleParameter("Rental_Seq", rental.Rental_Seq));
                cmd.Parameters.Add(new OracleParameter("Book_ISBN", rental.Book_ISBN));
                cmd.Parameters.Add(new OracleParameter("User_Phone", rental.User_Phone));
                cmd.Parameters.Add(new OracleParameter("Rental_Status", rental.Rental_Status));
                cmd.Parameters.Add(new OracleParameter("Rental_Date", rental.Rental_Date));
                cmd.Parameters.Add(new OracleParameter("Rental_Return_Date", rental.Rental_Return_Date));
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 기타 Read/Update/Delete는 UserRepository와 동일하게 구현

        public void Dispose()
        {
            if (_conn != null && _conn.State != ConnectionState.Closed)
                _conn.Close();
            _conn.Dispose();
        }
    }
}
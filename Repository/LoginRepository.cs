using BarcodeCaseA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BarcodeCaseA.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private string DBConnection;
        public LoginRepository()
        {
            DBConnection = ConfigurationManager.ConnectionStrings["DBConnectionAuth"].ConnectionString;
        }

        public LoginModel GetUserByUsername(string username)
        {
            using (var connection = new SqlConnection(DBConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT PasswordHash, NIK, Name FROM AspNetUsers WHERE NIK = @NIK";
                command.Parameters.Add("@NIK", SqlDbType.Int).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Nik = reader["NIK"].ToString();
                        string Name = reader["Name"].ToString();
                        string Password = reader["PasswordHash"].ToString();

                        return new LoginModel { Nik = Nik, Name = Name, Password = Password };
                    }
                    else
                    {
                        return null; // Pengguna tidak ditemukan
                    }
                }
            }
        }
    }
}

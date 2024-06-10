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
            DBConnection = ConfigurationManager.ConnectionStrings["DBConnectionCommon"].ConnectionString;
        }

        public LoginModel GetUserByUsername(string username)
        {
            using (var connection = new SqlConnection(DBConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT NikId, Name, Password FROM Users WHERE NikId = @Nik";
                command.Parameters.Add("@Nik", SqlDbType.Int).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nik = reader["NikId"].ToString();
                        string name = reader["Name"].ToString();
                        string password = reader["Password"].ToString();
                        return new LoginModel { Nik = nik, Name = name, Password = password };
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

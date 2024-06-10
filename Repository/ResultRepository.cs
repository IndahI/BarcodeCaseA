using BarcodeCaseA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BarcodeCaseA.Repository
{
    public class ResultRepository : IResultRepository
    {
        private string DBConnection_Packing;
        public ResultRepository() 
        {
            DBConnection_Packing = ConfigurationManager.ConnectionStrings["DBConnection_Packing"].ConnectionString;
        }

        public IEnumerable<CaseModel> GetAll()
        {
            List<CaseModel> models = new List<CaseModel>();
            string query = "SELECT * FROM Packing_Results WHERE CONVERT(DATE, date) = CONVERT(DATE, GETDATE()) ORDER BY Id DESC;";

            using (SqlConnection connection = new SqlConnection(DBConnection_Packing))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        models.Add(new CaseModel
                        {
                            Id = reader["Id"].ToString(),
                            Date = reader["Date"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            SerialNumber = reader["GlobalCodeId"].ToString(),
                            Adjustment = reader["Adjustment"].ToString(),
                            ModelCode = reader["ModelCodeId"].ToString(),
                            InspectorId = reader["InspectorId"].ToString()
                        });
                    }
                }
            }
            return models;
        }

        public IEnumerable<CaseModel> GetFilter(DateTime selectedDate)
        {
            List<CaseModel> results = new List<CaseModel>();
            string query = "SELECT * FROM Packing_Results WHERE CAST(Date AS DATE) = @SelectedDate ORDER BY Id DESC";

            using (SqlConnection connection = new SqlConnection(DBConnection_Packing))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add("@SelectedDate", SqlDbType.Date).Value = selectedDate.Date;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new CaseModel
                        {
                            Id = reader["Id"].ToString(),
                            Date = reader["Date"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            SerialNumber = reader["GlobalCodeId"].ToString(),
                            Adjustment = reader["Adjustment"].ToString(),
                            ModelCode = reader["ModelCodeId"].ToString(),
                            InspectorId = reader["InspectorId"].ToString()
                        });
                    }
                }
            }

            return results;
        }

        public (bool success, string errorMessage) addData(dynamic model)
        {
            using (var connection = new SqlConnection(DBConnection_Packing))
            {
                connection.Open();

                // Pengecekan apakah data sudah ada
                string checkQuery = "SELECT COUNT(*) FROM Packing_Results WHERE ModelCodeId = @ModelCode AND GlobalCodeId = @GlobalCodeId AND ModelNumber = @ModelNumber AND Adjustment = @Adjustment AND CONVERT(DATE, Date) = @Date";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@ModelCode", model.ModelCode);
                    checkCmd.Parameters.AddWithValue("@GlobalCodeId", model.SerialNumber);
                    checkCmd.Parameters.AddWithValue("@ModelNumber", model.ModelNumber);
                    checkCmd.Parameters.AddWithValue("@Adjustment", model.Adjustment);
                    checkCmd.Parameters.AddWithValue("@Date", model.Date);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return (false, "Data with the same value already exists.");
                    }
                }

                // Memasukkan data baru
                string insertQuery = "INSERT INTO Packing_Results (Date, ModelNumber, GlobalCodeId, Adjustment, ModelCodeId, InspectorId) VALUES (@Date, @ModelNumber, @GlobalCodeId, @Adjustment, @ModelCode, @InspectorId)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = model.Date;
                    insertCmd.Parameters.Add("@ModelNumber", SqlDbType.VarChar).Value = model.ModelNumber;
                    insertCmd.Parameters.Add("@GlobalCodeId", SqlDbType.VarChar).Value = model.SerialNumber;
                    insertCmd.Parameters.Add("@Adjustment", SqlDbType.VarChar).Value = model.Adjustment;
                    insertCmd.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = model.ModelCode;
                    insertCmd.Parameters.Add("@InspectorId", SqlDbType.VarChar).Value = model.InspectorId;
                    insertCmd.ExecuteNonQuery();
                }
            }
            return (true, null);
        }

        /***
        public void addData(dynamic model)
        {
            using (var connection = new SqlConnection(DBConnection_Packing))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Packing_Results (date, model_number, serial_number, result, model_code) values (@Date, @ModelNumber, @SerialNumber, @Result, @ModelCode)";
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = model.Date;
                command.Parameters.Add("@ModelNumber", SqlDbType.VarChar).Value = model.ModelNumber;
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = model.SerialNumber;
                command.Parameters.Add("@Result", SqlDbType.VarChar).Value = model.Result;
                command.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = model.ModelCode;
                command.ExecuteNonQuery();
            }
        }
        ***/
    }
}

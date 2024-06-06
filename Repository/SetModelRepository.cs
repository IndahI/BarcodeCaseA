using BarcodeCaseA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace BarcodeCaseA.Repository
{
    public class SetModelRepository : ISetModelRepository
    {
        private string DbConnectionCommon;

        public SetModelRepository()
        {
            DbConnectionCommon = ConfigurationManager.ConnectionStrings["DBConnectionCommon"].ConnectionString;
        }

        public List<string> GetData()
        {
            List<string> dataList = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DbConnectionCommon))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM GlobalModelCodes";
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            dataList.Add(reader["ModelNumber"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataList;
        }

        public string GetID(string selectedModel)
        {
            string serialNumber = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DbConnectionCommon))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT GlobalCodeId FROM GlobalModelCodes WHERE ModelNumber = @selectedModel";
                        command.Parameters.AddWithValue("@selectedModel", selectedModel);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            serialNumber = reader["GlobalCodeId"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                Console.WriteLine("Error: " + ex.Message);
            }

            return serialNumber;
        }

        public string GetModelCode(string selectedModel)
        {
            string modelCode = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DbConnectionCommon))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT ModelCodeId FROM GlobalModelCodes WHERE ModelNumber = @selectedModel";
                        command.Parameters.AddWithValue("@selectedModel", selectedModel);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            modelCode = reader["ModelCodeId"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                Console.WriteLine("Error: " + ex.Message);
            }

            return modelCode;
        }
    }
}

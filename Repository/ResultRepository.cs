﻿using BarcodeCaseA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string query = @"
                                SELECT 
                                    PR.Id,
                                    PR.Date, 
                                    PR.ModelNumber, 
                                    PR.GlobalCodeId, 
                                    PR.Adjustment,
                                    PR.ModelCodeId, 
                                    PR.ScanResult, 
                                    U.Name AS InspectorId
                                FROM Packing_Results PR
                                INNER JOIN LSBU_Common.dbo.Users U ON PR.InspectorId = U.NikId
                                WHERE CONVERT(DATE, PR.Date) = CONVERT(DATE, GETDATE()) 
                                ORDER BY PR.Id DESC;";

            using (SqlConnection connection = new SqlConnection(DBConnection_Packing))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CaseModel caseModel = new CaseModel
                        {
                            Id = reader["Id"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd"),
                            Time = Convert.ToDateTime(reader["Date"]).ToString("HH:mm:ss"),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            ScanResult = reader["ScanResult"].ToString(),
                            Adjustment = reader["Adjustment"].ToString(),
                            ModelCode = reader["ModelCodeId"].ToString(),
                            Inspector = reader["InspectorId"].ToString()
                        };
                        models.Add(caseModel);
                    }
                }
            }
            return models;
        }

        public IEnumerable<CaseModel> GetFilter(DateTime selectedDate)
        {
            List<CaseModel> results = new List<CaseModel>();
            string query = @"
                            SELECT 
                                PR.Id,
                                PR.Date, 
                                PR.ModelNumber, 
                                PR.GlobalCodeId, 
                                PR.Adjustment,
                                PR.ModelCodeId, 
                                PR.ScanResult,
                                U.Name AS InspectorId
                            FROM Packing_Results PR
                            INNER JOIN LSBU_Common.dbo.Users U ON PR.InspectorId = U.NikId
                            WHERE CAST(PR.Date AS DATE) = @SelectedDate
                            ORDER BY PR.Id DESC;";

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
                            Date = Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd"),
                            Time = Convert.ToDateTime(reader["Date"]).ToString("HH:mm:ss"),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            ScanResult = reader["ScanResult"].ToString(),
                            Adjustment = reader["Adjustment"].ToString(),
                            ModelCode = reader["ModelCodeId"].ToString(),
                            Inspector = reader["InspectorId"].ToString()
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

                // Memasukkan data baru
                string insertQuery = "INSERT INTO Packing_Results (Date, ModelNumber, GlobalCodeId, ScanResult, Adjustment, ModelCodeId, InspectorId) VALUES (@Date, @ModelNumber, @GlobalCodeId, @ScanResult, @Adjustment, @ModelCode, @InspectorId)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = model.Date;
                    insertCmd.Parameters.Add("@ModelNumber", SqlDbType.VarChar).Value = model.ModelNumber;
                    insertCmd.Parameters.Add("@GlobalCodeId", SqlDbType.VarChar).Value = model.GlobalCodeId;
                    insertCmd.Parameters.Add("@ScanResult", SqlDbType.VarChar).Value = model.ScanResult;
                    insertCmd.Parameters.Add("@Adjustment", SqlDbType.VarChar).Value = model.Adjustment;
                    insertCmd.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = model.ModelCode;
                    insertCmd.Parameters.Add("@InspectorId", SqlDbType.VarChar).Value = model.InspectorId;
                    insertCmd.ExecuteNonQuery();
                }
            }
            return (true, null);
        }
    }
}


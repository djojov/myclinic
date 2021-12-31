using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<string> GetReportData(int id) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> ListOfDiagnosis = new List<string>();
                string query = "SELECT d.first_name, d.last_name,r.date_admitted,diagnosis FROM patients p join reports r on p.id=r.patient_id JOIN doctors d on d.id=r.doctor_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string report = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                    ListOfDiagnosis.Add(report);
                }
                reader.Close();
                connection.Close();

                return ListOfDiagnosis;
            }
        }
        public int UpdateSelf(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET phone_number=@phoneNumber,weight=@weight,height=@height,email=@email,password=@password WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@phoneNumber", patient.PhoneNumber);
                command.Parameters.AddWithValue("@weight", patient.Weight);
                command.Parameters.AddWithValue("@height", patient.Height);
                command.Parameters.AddWithValue("@id", patient.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}

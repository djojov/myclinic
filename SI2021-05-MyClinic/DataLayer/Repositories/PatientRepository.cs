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
                string query = "SELECT d.first_name, d.last_name,r.date_admitted,diagnosis FROM patients p join reports r on p.id=r.patient_id JOIN doctors d on d.id=r.doctor_id WHERE patient_id=@id";
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
        public Patient GetPatient(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from Doctors WHERE email=@email AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                Patient patient = new Patient();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patient.Id = reader.GetInt32(0);
                    patient.FirstName = reader.GetString(1);
                    patient.LastName = reader.GetString(2);
                    patient.PersonalNumber = reader.GetString(3);
                    patient.HealthInsuranceNumber = reader.GetString(4);
                    patient.DateOfBirth = reader.GetDateTime(5);
                    patient.PlaceOfBirth = reader.GetString(6);
                    patient.Email = reader.GetString(7);
                    patient.Password = reader.GetString(8);
                    patient.PhoneNumber = reader.GetString(9);
                    patient.Weight = reader.GetString(10);
                    patient.Height = reader.GetString(11);
                }
                reader.Close();
                connection.Close();
                return patient;
            }
        }
        public float CalculateBMI(string weight, string height)
        {
            int w = Convert.ToInt32(weight);
            int h = Convert.ToInt32(height);

            float bmi = (float)w / h / h * 10000;
            return bmi;
        }
    }
}

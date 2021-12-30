using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class DoctorRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<Patient> GetAllPatients()
        {
            List<Patient> ListofPatients = new List<Patient>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from PATIENTS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.Id = reader.GetInt32(0);
                    patient.FirstName = reader.GetString(1);
                    patient.LastName = reader.GetString(2);
                    patient.PersonalNumber = reader.GetString(3);
                    patient.HealthInsuranceNumber = reader.GetString(4);
                    patient.DateOfBirth = reader.GetDateTime(5);
                    patient.PlaceOfBirth = reader.GetString(6);
                    patient.PhoneNumber = reader.GetString(9);
                    patient.Weight = reader.GetString(10);
                    patient.Height = reader.GetString(11);
                    ListofPatients.Add(patient);
                }
                reader.Close();
                connection.Close();

                return ListofPatients;
            }
        }
        public int UpdatePatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET first_name=@firstName,last_name=@lastName,personal_number=@personalNumber,health_insurance_number=@HINumber,date_of_birth=@dob,place_of_birth=@pob,phone_number=@phoneNumber,weight=@weight,height=@height WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", patient.FirstName);
                command.Parameters.AddWithValue("@lastName", patient.LastName );
                command.Parameters.AddWithValue("@personalNumber", patient.PersonalNumber);
                command.Parameters.AddWithValue("@HINumber", patient.HealthInsuranceNumber);
                command.Parameters.AddWithValue("@dob", patient.DateOfBirth );
                command.Parameters.AddWithValue("@pob", patient.PlaceOfBirth);
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

        public int InsertPatient(Patient patient) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PATIENTS (first_name,last_name,personal_number,health_insurance_number,date_of_birth,place_of_birth,email,password,phone_number,weight,height) VALUES(@firstName,@lastName,@personalNumber,@HINumber,@dob,@pob,@email,'mypass123',@phoneNumber,@weight,@height)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", patient.FirstName);
                command.Parameters.AddWithValue("@lastName", patient.LastName);
                command.Parameters.AddWithValue("@personalNumber", patient.PersonalNumber);
                command.Parameters.AddWithValue("@HINumber", patient.HealthInsuranceNumber);
                command.Parameters.AddWithValue("@dob", patient.DateOfBirth);
                command.Parameters.AddWithValue("@pob", patient.PlaceOfBirth);
                command.Parameters.AddWithValue("@email", patient.Email);
                command.Parameters.AddWithValue("@phoneNumber", patient.PhoneNumber);
                command.Parameters.AddWithValue("@weight", patient.Weight);
                command.Parameters.AddWithValue("@height", patient.Height);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}

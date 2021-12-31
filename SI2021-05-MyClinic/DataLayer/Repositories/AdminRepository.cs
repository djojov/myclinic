using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminRepository : IAdminRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> ListOfDoctors = new List<Doctor>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from DOCTORS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Doctor doc = new Doctor();
                    doc.Id = reader.GetInt32(0);
                    doc.Status = reader.GetBoolean(1);
                    doc.FirstName = reader.GetString(2);
                    doc.LastName = reader.GetString(3);
                    doc.PersonalNumber = reader.GetString(4);
                    doc.PhoneNumber = reader.GetString(5);
                    doc.DateEmployed = reader.GetDateTime(6);
                    doc.Specialization = reader.GetString(7);
                    doc.Department = reader.GetString(8);
                    doc.Email = reader.GetString(9);
                    doc.Password = reader.GetString(10);
                    ListOfDoctors.Add(doc);
                }
                reader.Close();
                connection.Close();

                return ListOfDoctors;
            }
        }
        public int UpdateDoctor(Doctor doc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DOCTORS SET status=@status,first_name=@firstName,last_name=@lastName,personal_number=@personalNumber,phone_number=@phoneNumber,date_employed=@dateEmployed,specialization=@specialization,department=@department,email=@email,password=@password WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", doc.Status);
                command.Parameters.AddWithValue("@firstName", doc.FirstName);
                command.Parameters.AddWithValue("@lastName", doc.LastName);
                command.Parameters.AddWithValue("@personalNumber", doc.PersonalNumber);
                command.Parameters.AddWithValue("@phoneNumber", doc.PhoneNumber);
                command.Parameters.AddWithValue("@dateEmployed", doc.DateEmployed);
                command.Parameters.AddWithValue("@specialization", doc.Specialization);
                command.Parameters.AddWithValue("@department", doc.Department);
                command.Parameters.AddWithValue("@email", doc.Email);
                command.Parameters.AddWithValue("@password", doc.Password);
                command.Parameters.AddWithValue("@id", doc.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public int InsertDoctor(Doctor doc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DOCTORS (status,first_name,last_name,personal_number,phone_number,date_employed,specialization,department,email,password,admin_id) VALUES(1,@firstName,@lastName,@personalNumber,@phoneNumber,@dateEmployed,@specialization,@department,@email,@password,1)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", doc.FirstName);
                command.Parameters.AddWithValue("@lastName", doc.LastName);
                command.Parameters.AddWithValue("@personalNumber", doc.PersonalNumber);
                command.Parameters.AddWithValue("@phoneNumber", doc.PhoneNumber);
                command.Parameters.AddWithValue("@dateEmployed", doc.DateEmployed);
                command.Parameters.AddWithValue("@specialization", doc.Specialization);
                command.Parameters.AddWithValue("@department", doc.Department);
                command.Parameters.AddWithValue("@email", doc.Email);
                command.Parameters.AddWithValue("@password", doc.Password);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}

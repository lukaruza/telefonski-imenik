using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ContactRepository
    {
        public List<Contact> GetAllContacts()
        {
            List<Contact> results = new List<Contact>();

            using (SqlConnection sqlconnection = new SqlConnection(Constant.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlconnection;
                sqlCommand.CommandText = "SELECT * FROM Contacts";

                sqlconnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Contact s = new Contact();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.Surname = sqlDataReader.GetString(2);
                    s.PhoneNumber = sqlDataReader.GetString(3);
                    s.Fax = sqlDataReader.GetString(4);
                    s.Email = sqlDataReader.GetString(5);
                    s.Address = sqlDataReader.GetString(6);
                    s.Description = sqlDataReader.GetString(7);

                    results.Add(s);
                }
            }

            return results;
        }
        public int InsertContact(Contact s)
        {
            using (SqlConnection sqlconnection = new SqlConnection(Constant.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlconnection;
                sqlCommand.CommandText = 
                    string.Format("INSERT INTO Contacts VALUES ({0}, {1}, '{2}', '{3}', {4}, {5}, {6}, {7}",s.Name, s.Surname, s.PhoneNumber, s.Fax, s.Email, s.Address, s.Description);
                return sqlCommand.ExecuteNonQuery();
            }

        }
    }
}

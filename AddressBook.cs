using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDOTNet
{
    public class AddressBook
    {
        string connection = $"Data source= DESKTOP-NT8GQRL; Database = AddressBook; Integrated Security = true ";
        SqlConnection sqlConnection;
        
       public AddressBook()
        {
            sqlConnection = new SqlConnection(connection);
        }

        public void AddContact(Contact contact)
        {

            sqlConnection.Open();


            string query = $"INSERT INTO contacts VALUES ('{contact.FirstName}','{contact.LastName}','{contact.Email}','{contact.PhoneNumber}','{contact.City}','{contact.SState}','{contact.Zip}')";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine($"{result} is affected");
            }

            sqlConnection.Close();


        }

        public void Display()
        {
            List<Contact> contactslist = new List<Contact>();
            sqlConnection.Open();
            string query = "SELECT * FROM contacts";
            SqlCommand view = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact()
                {
                    ID = (int)reader["ID"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Email = (string)reader["Email"],
                    PhoneNumber = (string)reader["PhoneNumber"],
                    City = (string)reader["City"],
                    SState = (string)reader["SState"],
                    Zip = (string)reader["Zip"]
                };
                contactslist.Add(contact);
            }

            foreach (Contact contact in contactslist)
            {

                Console.WriteLine($"ID:- {contact.ID}\t Name:- {contact.FirstName}\t LastName:- {contact.LastName} \tPhoneNumber:- {contact.PhoneNumber}  \tEmail:- {contact.Email} \tCity:- {contact.City} \tState:- {contact.SState} \tPinCode:- {contact.Zip}");
            }


            sqlConnection.Close();


        }


    }
}

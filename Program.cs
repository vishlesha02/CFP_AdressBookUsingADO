﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDOTNet
{
    public class Program
    {

        public static void Main(String[] args)
        {
            AddressBook obj = new AddressBook();
            while (true)
            {

                Console.WriteLine("Press 1 to Add Contact");
                Console.WriteLine("Press 2 to Display Contact");
                Console.WriteLine("Press 3 to Display Single Contact");
                Console.WriteLine("Press 4 to Delete Contact");
                Console.WriteLine("Press 5 to Edit Contact");

            

            Console.WriteLine("Enter your choice");
            int choice=int.Parse(Console.ReadLine());
           
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Firstname: - ");
                            string first = Console.ReadLine();
                            Console.WriteLine("Enter LastName");
                            string last = Console.ReadLine();
                            Console.WriteLine("Enter PhoneNumber");
                            string phno = Console.ReadLine();

                            Console.WriteLine("Enter Email:- ");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter City:- ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter Pincode:- ");
                            string zipcode = Console.ReadLine();
                            Console.WriteLine("Enter State:- ");
                            string state = Console.ReadLine();

                            Contact contact = new Contact(first, last, phno, email, city, state, zipcode);
                            /*{
                                FirstName = FirstName,
                                LastName = LastName,
                                PhoneNumber = PhoneNumber,
                                Email = Email,
                                City = City,
                                SState = State,
                                Zip = Zip,
                            };*/
                            obj.AddContact(contact);
                            break;
                        }
                    
                    default:
                        break;
                }
            }

           


        }

    }
}    
    
    


    


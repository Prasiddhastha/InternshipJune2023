using EntityPrac.Data;

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPrac
{
    public class Practice
    {
        //private static string connectionString = @"Server=MercylessBeast\SQLEXPRESS;Database=JuneInternship;Trusted_Connection=True;trustServerCertificate=true";
        private  readonly DataContext _context;
        public Practice(DataContext context)
        {
            _context = context;
        }

        public  void AddCustomers(Customer customer)
        {
            Console.WriteLine("Enter Name:");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            customer.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone:");
            customer.Phone = Console.ReadLine();

            Console.WriteLine("Enter City:");
            customer.City = Console.ReadLine();

            _context.Customers.Add(customer);
            _context.SaveChanges();

            Console.WriteLine("Data Added");
            GetCustomers();
        }

        public void GetCustomers()
        {
            _context.Customers.ToList();
            foreach (var customer in _context.Customers)
            {
                Console.WriteLine($"{customer.CustomerId}. {customer.Name}--{customer.Email}--{customer.City}--{customer.Phone}");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            var dbCustomer = _context.Customers.Find(id);
            if (dbCustomer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }

            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                dbCustomer.Name = name;
            }

            Console.WriteLine("Enter Email:");
            var email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email))
            {
                dbCustomer.Email = email;
            }

            Console.WriteLine("Enter Phone:");
            var phone = Console.ReadLine();
            if (!string.IsNullOrEmpty(phone))
            {
                dbCustomer.Phone = phone;
            }

            Console.WriteLine("Enter City:");
            var city = Console.ReadLine();
            if (!string.IsNullOrEmpty(city))
            {
                dbCustomer.City = city;
            }

            _context.SaveChanges();

            Console.WriteLine("Customer updated");
            GetCustomers();

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            var dbCustomer = _context.Customers.Find(id);
            if (dbCustomer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }

            _context.Customers.Remove(dbCustomer);
            _context.SaveChanges();
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand command = connection.CreateCommand())
            //    {
            //        command.CommandText = $"Dbcc CheckIdent('Customers',RESEED,{id - 1}";

            //        connection.Open();
            //    }
            //}
            //Console.WriteLine("Deleted");
            GetCustomers();
        }

        public void GetCustomerById(Customer customer)
        {
            Console.WriteLine("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            var dbCustomer = _context.Customers.Find(id);
            if (dbCustomer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }

                Console.WriteLine($"{dbCustomer.CustomerId}. {dbCustomer.Name}--{dbCustomer.Email}--{dbCustomer.City}--{dbCustomer.Phone}");
            
        }
    }
}


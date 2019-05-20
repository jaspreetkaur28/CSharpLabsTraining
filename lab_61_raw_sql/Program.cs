using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lab_61_raw_sql
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(
                @"Data Source= localhost; Initial Catalog = Northwind; Persist Security Info = True; 
                                                                                        User ID = SA; Password=Passw0rd2018"
             ))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                //INSERT
              
                var newCustomer = new Customer("TEST", "TEST", "TEST", "TEST");
                String SQLInsert = $"Insert into Customers ( CustomerID,  CompanyName, ContactName ) Values ('{newCustomer.CustomerID}', '{newCustomer.CompanyName}', '{newCustomer.ContactName}' )";
                Console.WriteLine(SQLInsert);
                using (var command = new SqlCommand(SQLInsert, connection))
                {   int newData = command.ExecuteNonQuery();
                    Console.WriteLine("the number of records added:" + newData);
                }                
                #region Another way to insert
                /*

                //
                string SQLSelect2 = "Insert into Customers ( CustomerID,  CompanyName, ContactName ) Values (@CustomerID, @CompanyName, @ContactName )";

                using (var command1 = new SqlCommand(SQLSelect2, connection))
                {
                    command1.Parameters.AddWithValue("@CustomerID", "abc");
                    command1.Parameters.AddWithValue("@CompanyName", "abc");
                    command1.Parameters.AddWithValue("@ContactName", "abc");

                    command1.ExecuteNonQuery();
                } */
                #endregion

  //Update One Customer   
                string SQLUpdate = $"Update Customers Set City ='Berlin' where CustomerId='TEST'";
                Console.WriteLine(SQLUpdate);
                using (var command = new SqlCommand(SQLUpdate, connection))
                {   int newData = command.ExecuteNonQuery();
                    Console.WriteLine("the number of records edited:" + newData);
                }
 //Delete                 
                string SQLDelete = $"Delete From Customers Where CustomerID ='TEST'";
                Console.WriteLine(SQLDelete);
                using (var command = new SqlCommand(SQLDelete, connection))
                {   int newData = command.ExecuteNonQuery();
                    Console.WriteLine("the number of records deleted:" + newData);
                }

 //read customers 
                string SQLSelect = "select * from customers";
                using (var command = new SqlCommand(SQLSelect, connection))
                {   SqlDataReader sqlreader = command.ExecuteReader();
                    while (sqlreader.Read())
                    {   string CustomerID = sqlreader["CustomerID"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string ContactName = sqlreader["ContactName"].ToString();
                        string City = sqlreader["City"].ToString();
                        var customer = new Customer(CustomerID, CompanyName, ContactName, City);
                        customers.Add(customer);
                    }
                }


            }

 //print out data 

            customers.ForEach(c => { Console.WriteLine($"{c.CustomerID,-10} is {c.ContactName,-30} from {c.CompanyName,-40} in {c.City}"); });


        }
    }
    internal class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public Customer(string CustomerID, String CompanyName, string ContactName, string City)
        {
            this.CustomerID = CustomerID;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.City = City;
        }
        public Customer() { } // default constructor 
    }
}

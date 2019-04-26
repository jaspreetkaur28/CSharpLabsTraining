using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_44_entity
{
    class Program
    {

        static List<Customer> customerList; // All
        static Customer customer; //one
        static Customer newCustomer;
        static void Main(string[] args)
        {
            /*using (var db = new NorthwindEntities2())
            {
                customerList =
                   (from c in db.Customers
                    select c).ToList<Customer>();


                foreach (Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, Name : {c.ContactName}, City : {c.City}");
                }
                customer = db.Customers.Where(customer => customer.CustomerID == "FRANK").FirstOrDefault();
                customer.City = "BERLIN";
                db.SaveChanges(); 

            }
            */



            //Check the database has worked from scratch 
           /* using (var db = new NorthwindEntities2())
            {
                foreach (Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, Name : {c.ContactName}, City : {c.City}");
                }
                //LINQ LAMDA QUERY
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                Console.WriteLine($"ID : {customer.CustomerID}, Name : {customer.ContactName}, City : {customer.City}");
                //LINQ STANDARD
                customer = (from cust in db.Customers
                            where cust.CustomerID == "ZAAA"
                            select cust).FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID} {customer.ContactName} {customer.City}");

                
            } */

            //adding query
            using (var db = new NorthwindEntities2())
            {
                newCustomer = new Customer()
                {
                    CustomerID = "ZAAK",
                    ContactName = "BOB",
                    CompanyName="SpartaGlobal",
                    City = "LONDON"
                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            } 


            //DELETE RECORD 
        /*    using (var db = new NorthwindEntities2())
            {
               // Console.WriteLine($"{customer.CustomerID} {customer.ContactName} {customer.City}");

                //select
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();

                //delete
                db.Customers.Remove(customer);
                db.SaveChanges();
            } */



            //Query TO SEE THE NEW ADDED DATA
            using (var db = new NorthwindEntities2())
            {
                customer = db.Customers.Where(cust => cust.CustomerID == "ZAAK").FirstOrDefault();


                if (customer != null)
                {
                    Console.WriteLine($"{customer.CustomerID} {customer.ContactName} {customer.City}");
                }
                else
                {
                    Console.WriteLine($"Doesnt exist");
                }


            }
            using (var db = new NorthwindEntities2())
            {
                customerList =
                    (from c in db.Customers
                     select c).ToList<Customer>();


                foreach (Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, Name : {c.ContactName}, City : {c.City}");
                }
            }


        }
        }
}

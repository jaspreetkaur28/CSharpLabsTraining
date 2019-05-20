using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_43_Entity
{
    class Program
    {
        static Customer customerToUpdate;
        static Customer FindOneCustomer;
        static void Main(string[] args)
        {
            //automatically cleans up the database connection when it completed
            //doesnt use up anymore memory and leave unwanted stuff
           /* using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CustomerID);
                }
                foreach (var c  in customers)
                {
                    Console.WriteLine($"ID is {c.CustomerID}, name is {c.ContactName}");
                }

                //Update one customer 
                // all customers where (just select the one with the right id). Just choose first 
                customerToUpdate = db.Customers.Where(cust=>cust.CustomerID == "ALFKI").FirstOrDefault();
                //cust is declared here like int i.
                customerToUpdate.City = "Hellooo";
                db.SaveChanges();
             

            }


            using (var db = new NorthwindEntities())
            {
                FindOneCustomer =
                    (from cust in db.Customers //cust is like int i - you just name it urself. its being declared here
                     where cust.CustomerID == "ALFKI"
                     select cust).FirstOrDefault();
                //CALLED Link
                Console.WriteLine($"\n\nUpdated customer has new city = {FindOneCustomer.City}");
            }

                try {// contact DB
            }
            catch { //any errors
            }
            finally { //close database
            }
            */




        }
    }
}

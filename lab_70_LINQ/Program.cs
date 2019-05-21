using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_70_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //LINQ select 
            //Data Type is IQUERYABLE which means DATA NOT LOADED UNTIL ACTUALLY NEEDED
            //Lazy Loading

            using (var db = new Northwind())
            {/*
                var customers =
                    from customer in db.Customers
                    where customer.City == "Berlin" || customer.City == "London"
                    select customer; 
                //Data actually loaded here 
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerID,-15} {customer.ContactName,-20} from {customer.City}" );
                }
                
                //FIND Customer Via PK
                var oneCustomer = db.Customers.Find("ALFKI"); // only works with primary key 
                Console.WriteLine($"One Customer is {oneCustomer.ContactName} from {oneCustomer.City}");


                //ORDERBY 
                var allCustomers =
                    from c in db.Customers
                    orderby c.City
                    select c;
                foreach (var customer in allCustomers)
                {
                    Console.WriteLine($"{customer.CustomerID,-15} {customer.ContactName,- 30} from {customer.City}");
                }

                //Create new output object 
                Console.WriteLine("\n\nCreating Custom Objects\n\n"); // CREATE NEW OUTPUT OBJECT 
                var customOutputObject =
                    from c in db.Customers
                    orderby c.Country, c.City 
                    select c;
                foreach (var customer in customOutputObject)
                {
                    Console.WriteLine($"{customer.CustomerID,-15} {customer.ContactName,-30} from {customer.Country, -10} {customer.City} ");

                }

                var customOutputObject2 =
                    from c in db.Customers
                    orderby c.Country, c.City
                    select new
                    {   ID=c.CustomerID,
                        Name = c.ContactName,
                        Location = c.City + " in " + c.Country 
                    };
                foreach(var c in customOutputObject2)
                {
                    Console.WriteLine($"{c.ID,-10} {c.Name,-20} from {c.Location}");
                }

                Console.WriteLine("\n\nNow also create a custom type\n\n");
                Console.WriteLine(Environment.NewLine); // same as \n\n but use this for proper work. 
                // USING CLASS CustomObject 
                var customOutputObject3 =
                    (from cu in db.Customers
                    orderby cu.Country, cu.City
                    select new CustomObject()
                    {
                        ID = cu.CustomerID,
                        Name = cu.ContactName,
                        Location = cu.City + " in " + cu.Country
                    }).ToList();

                customOutputObject3.ForEach(item => Console.WriteLine($"{item.ID,-10} {item.Name,-30}  from {item.Location}"));
              

                var results =  customOutputObject3.Any(c => c.Name == "Jaspreet");
              
                var results2 = customOutputObject3.Any(c => c.ID == "ALFKI");
                Console.WriteLine(results); // true 

    */



                Console.WriteLine("\n\nLink GroupBy\n\n");
                // Create 'cities' object holding customers by city 
                var CountCustomersByCity =
                from Customer in db.Customers
                group Customer by Customer.City into cities
                orderby cities.Count() descending
                select new
                {
                    City = cities.Key,
                    Count = cities.Count()

                };
               foreach (var item in CountCustomersByCity)
                {
                    Console.WriteLine($"{item.City,-30} Count: {item.Count}");
                }



            } 
        }
    }

    class CustomObject
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }


}

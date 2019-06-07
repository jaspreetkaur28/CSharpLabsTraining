
using lab_93_Entity_XML.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace lab_93_Entity_XML
{
    class Program
    {
        static List<Product> ProductList;
        static List<Product> productSimpleList;
        static Product product = new Product();
        static Product product2 = new Product();

        static void Main(string[] args)
        {

            //string xmlString = "<products><ID>1</ID><Name>Chai</Name><UnitPrice>18.0000</UnitPrice><Quantity>10 boxes x 20 bags</Quantity><ReorderLevel>10</ReorderLevel><CategoryID>1</CategoryID></products>";
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            //StringReader stringReader = new StringReader(xmlString);
            //ProductList = (List<Product>)serializer.Deserialize(stringReader);



            using (var db = new Northwind())
            {

                ProductList = db.Products.ToList();

                //   ProductList.ForEach(o => Console.WriteLine(o.ProductName));

                product = ProductList.FirstOrDefault();

              product2 = ProductList.Skip(1).FirstOrDefault();
              var xmlProduct =
              new XElement("products",
              new XElement("ID", product.ProductID),
              new XElement("Name", product.ProductName),
              new XElement("UnitPrice", product.UnitPrice),
              new XElement("Quantity", product.QuantityPerUnit),
              new XElement("ReorderLevel", product.ReorderLevel),
              new XElement("CategoryID", product.CategoryID)
              );

                Console.WriteLine(xmlProduct);

                //  xmlProduct.Save("ProductsList.xml");


                //   loop

                var xmlProduct2 = new XElement("products",
                from pl in ProductList
                select new XElement("products",
                new XElement("ID", pl.ProductID),
                new XElement("Name", pl.ProductName),
                new XElement("UnitPrice", pl.UnitPrice),
                new XElement("Quantity", pl.QuantityPerUnit),
                new XElement("ReorderLevel", pl.ReorderLevel),
                new XElement("CategoryID", pl.CategoryID)
                ));

                Console.WriteLine(xmlProduct2);


                //write new file to cml then de-serialize it back 
                //write new file
                productSimpleList = db.Products.ToList();


                var xmlProductsOutput = new XElement(
                    "Products",
                    from p in productSimpleList
                    select new XElement("Product",
                new XElement("ProductID", p.ProductID),
                new XElement("ProductName", p.ProductName), 
                new XElement("CategoryID", p.CategoryID)
                ));
             //   xmlProductsOutput.Save("xmlProductsOutput3.xml");



                // lets deserialise now! 

                Console.WriteLine("\n\nPrinting out list of Deserialized Products\n\n");

                var productsDeserialized = new Products();
                using (var reader = new StreamReader("xmlProductsOutput3.xml")) //reading the file
                {
                    var serialiser = new XmlSerializer(typeof(Products));
                    productsDeserialized = (Products)serialiser.Deserialize(reader);
                }
                //at this point products Deserialized shuld hold our Product List 

                productsDeserialized.ProductList.ForEach(p =>
                {
                    Console.WriteLine($"{p.ProductID,-10} {p.ProductName,-45} {p.CategoryID}");
                }); 

            }

        }
    } 
    //Annotation to let the system know part of the deserializion
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }
}


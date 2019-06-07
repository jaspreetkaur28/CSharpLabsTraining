
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
        static Product product = new Product();
        static Product product2 = new Product();

        static void Main(string[] args)
        {

            string xmlString = "<products><ID>1</ID><Name>Chai</Name><UnitPrice>18.0000</UnitPrice><Quantity>10 boxes x 20 bags</Quantity><ReorderLevel>10</ReorderLevel><CategoryID>1</CategoryID></products>";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            StringReader stringReader = new StringReader(xmlString);
            ProductList = (List<Product>)serializer.Deserialize(stringReader);



            //using (var db = new Northwind())
            //{

            //    ProductList = db.Products.ToList();

            //    //   ProductList.ForEach(o => Console.WriteLine(o.ProductName));

            //    product = ProductList.FirstOrDefault();

            //    product2 = ProductList.Skip(1).FirstOrDefault();
            //    var xmlProduct =
            //  new XElement("products",
            //  new XElement("ID", product.ProductID),
            //  new XElement("Name", product.ProductName),
            //  new XElement("UnitPrice", product.UnitPrice),
            //  new XElement("Quantity", product.QuantityPerUnit),
            //  new XElement("ReorderLevel", product.ReorderLevel),
            //  new XElement("CategoryID", product.CategoryID)
            //  );

            //    Console.WriteLine(xmlProduct);

                //save to file 
           //     xmlProduct.Save("xmlOneProductv1.xml");
                //They do the same thing!
                //save to file 
     //           var xmlProductSave = new XDocument(XElement.Parse(xmlProduct.ToString()));
    //            xmlProductSave.Save("xmlOneProductv2.xml");




                //loop

              //  var xmlProduct2 = new XElement("products",
              //from p in ProductList
              //select new XElement("products",
              //new XElement("ID", p.ProductID),
              //new XElement("Name", p.ProductName),
              //new XElement("UnitPrice", p.UnitPrice),
              //new XElement("Quantity", p.QuantityPerUnit),
              //new XElement("ReorderLevel", p.ReorderLevel),
              //new XElement("CategoryID", p.CategoryID)
              //));

              //  Console.WriteLine(xmlProduct2);






                // me messing around
                //for (int i = ProductList.Count - 1; i >= 0; i++)
                //{
                //    product = ProductList.Skip(i).FirstOrDefault();
                //    var xmlProduct3 =
                //  new XElement("products",
                //  new XElement("ID", product.ProductID),
                //  new XElement("Name", product.ProductName),
                //  new XElement("UnitPrice", product.UnitPrice),
                //  new XElement("Quantity", product.QuantityPerUnit),
                //  new XElement("ReorderLevel", product.ReorderLevel),
                //  new XElement("CategoryID", product.CategoryID)
                //  );

                //    Console.WriteLine(xmlProduct3);

                //}
                
          //  }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace lab_93_Entity_XML
{
    public partial class Product
    {

        //public Product()
        //{
        //    Order_Details = new HashSet<Order_Detail>();
        //}

        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

      //  public virtual Category Category { get; set; }


    }
}

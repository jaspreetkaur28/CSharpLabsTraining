namespace lab_93_XML_B_Products
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPARTANS")]
    public partial class SPARTAN
    {
        public int SpartanId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string University { get; set; }

        [StringLength(50)]
        public string Course { get; set; }

        public int? Mark { get; set; }

        [Column(TypeName = "date")]
        public DateTime? YearOfGrad { get; set; }
    }
}

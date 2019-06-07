namespace lab_93_XML_B_Products
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        [Key]
        [Column(Order = 0)]
        public int TaskID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TaskName { get; set; }

        public bool? Done { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStarted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCompleted { get; set; }

        public int? CategoryID { get; set; }

        public int? UserID { get; set; }
    }
}

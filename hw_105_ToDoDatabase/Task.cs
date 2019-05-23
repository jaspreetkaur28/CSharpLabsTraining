namespace hw_105_ToDoDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int TaskID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        public bool? Done { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStarted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCompleted { get; set; }

        public int? CategoryID { get; set; }

        public int? UserID { get; set; }

        public virtual Category Category { get; set; }

        public virtual User User { get; set; }
    }
}

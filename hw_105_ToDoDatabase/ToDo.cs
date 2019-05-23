namespace hw_105_ToDoDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class ToDo : DbContext
    {
        public ToDo()
            : base("name=ToDo")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public IEnumerable<object> User { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

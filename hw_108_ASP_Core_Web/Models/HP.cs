using Microsoft.EntityFrameworkCore;
  
namespace hw_108_ASP_Core_Web.Models
{

    public class HP : DbContext
    {
 
        public DbSet<Character> Characters { get; set; }  
        public DbSet<Actor> Actors { get; set; }  

        public HP() { }

        public HP(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "HP.db");
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=HP;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }


        void viewcustomers()
        {
            using (var db = new HP())
            {// create a list of customers and display them! }

                

            }
        }
    }
}

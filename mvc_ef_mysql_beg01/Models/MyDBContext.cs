namespace mvc_ef_mysql_beg01.Models
{
    using System.Data.Entity;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MySQLConnection")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Student>()
            //    .Property(e => e.Class)
            //    .IsUnicode(false);
        }
    }
}

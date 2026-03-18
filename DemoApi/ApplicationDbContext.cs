using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Employee>(b =>
            {
                b.ToTable("Employees", DemoSchema.AccountDbSchema);
                b.Property(x => x.Email).IsRequired();
                b.Property(x => x.Password).IsRequired();
                b.Property(x => x.FirstNameEn).IsRequired();
                b.Property(x => x.SecondNameEn).IsRequired();
                b.Property(x => x.ThirdNameEn).IsRequired();
                b.Property(x => x.LastNameEn).IsRequired();
                b.Property(x => x.FirstNameAr).IsRequired();
                b.Property(x => x.SecondNameAr).IsRequired();
                b.Property(x => x.ThirdNameAr).IsRequired();
                b.Property(x => x.LastNameAr).IsRequired();
                b.Property(x => x.DateOfBirth).IsRequired();
                b.Property(x => x.Gender).IsRequired();
                b.Property(x => x.MaritalStatus).IsRequired();
                b.Property(x => x.NationalNumber).IsRequired();
                b.Property(x => x.PhoneNumber).IsRequired();
            });
        }
    }
}

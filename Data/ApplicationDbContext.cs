using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "John", LastName = "Doe", Address = "123 Main St", Email = "john.doe@example.com", Phone = "123-456-7890", DateOfBirth = new DateTime(1990, 1, 1) },
                new Employee { EmployeeId = 2, Name = "Jane", LastName = "Smith", Address = "456 Elm St", Email = "jane.smith@example.com", Phone = "987-654-3210", DateOfBirth = new DateTime(1992, 2, 2) }
                );
            modelBuilder.Entity<LeaveType>().HasData(
                new LeaveType { LeaveTypeId = 1, TypeName = "Holiday" },
                new LeaveType { LeaveTypeId = 2, TypeName = "Sick Leave" },
                new LeaveType { LeaveTypeId = 3, TypeName = "Care of Children" }
                );
            modelBuilder.Entity<LeaveApplication>().HasData(
                new LeaveApplication
                {
                    LeaveApplicationId = 1,
                    StartDate = DateTime.Parse("2023-05-01"),
                    EndDate = DateTime.Parse("2032-05-10"),
                    CreatedDate = DateTime.Now,
                    EmployeeId = 1,
                    LeaveTypeId = 1,
                },
                new LeaveApplication
                {
                    LeaveApplicationId = 2,
                    StartDate = DateTime.Parse("2023-05-01"),
                    EndDate = DateTime.Parse("2025-05-10"),
                    CreatedDate = DateTime.Now,
                    EmployeeId = 2,
                    LeaveTypeId = 2,
                }
                );
            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}

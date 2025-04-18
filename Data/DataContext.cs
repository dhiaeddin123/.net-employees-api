using blockchain_api.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blockchain_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<LeaveRequest> LeaveRequests => Set<LeaveRequest>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeaveRequest>()
                .Property(lr => lr.LeaveType)
                .HasConversion<string>();

            modelBuilder.Entity<LeaveRequest>()
                .Property(lr => lr.Status)
                .HasConversion<string>();
                
            modelBuilder.Entity<LeaveRequest>()
                .Property(lr => lr.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id=1, FullName="Dhiaeddine Boukthir", Department="Fullstack Developer", JoiningDate=new DateOnly(2023, 07, 21)},
                new Employee { Id=2, FullName="Abdelkader Mbarek", Department="Frontend Developer", JoiningDate=new DateOnly(2022, 11, 07)}
            );
            modelBuilder.Entity<LeaveRequest>().HasData(
                new LeaveRequest { Id=1, EmployeeId=1, LeaveType=LeaveType.Annual, Status=LeaveRequestStatus.Pending, Reason="Found another job offer", StartDate=new DateOnly(2025, 02, 07), EndDate=null, CreatedAt=new DateTime(2025, 04, 17, 18, 00, 00)}
                // new Employee { Id=1, FullName="Abdelkader Mbarek", Department="Frontend Developer", JoiningDate=new DateOnly(2022, 11, 07)}
            );
        }
    }
}
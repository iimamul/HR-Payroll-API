using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HR_Payroll_API.Entities;

public partial class HrPayrollContext : DbContext
{
    public HrPayrollContext()
    {
    }

    public HrPayrollContext(DbContextOptions<HrPayrollContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=192.168.0.23;Database=T_HR_Payroll;User Id=sa;Password=Retail@production;Trusted_Connection=True; TrustServerCertificate=True; Integrated Security=False;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Employee>(entity =>
    //    {
    //        entity.ToTable("Employee");

    //        entity.Property(e => e.Department).HasMaxLength(50);
    //        entity.Property(e => e.EmployeeCode).HasMaxLength(50);
    //        entity.Property(e => e.EmployeeName).HasMaxLength(500);
    //    });

    //    modelBuilder.Entity<LeaveBalance>(entity =>
    //    {
    //        entity.ToTable("LeaveBalance");

    //        entity.Property(e => e.LeaveName).HasMaxLength(500);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

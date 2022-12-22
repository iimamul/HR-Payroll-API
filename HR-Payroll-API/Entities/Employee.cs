using System;
using System.Collections.Generic;

namespace HR_Payroll_API.Entities;

public partial class Employee
{
    public int Id { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeCode { get; set; }

    public string? Department { get; set; }
}

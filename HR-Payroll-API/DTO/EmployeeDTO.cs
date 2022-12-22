using System;
using System.Collections.Generic;

namespace HR_Payroll_API.DTO;

public partial class EmployeeDTO
{
    public int Id { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }
}

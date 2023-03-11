using HR_Payroll_API.Entities;
using System;
using System.Collections.Generic;

namespace HR_Payroll_API.DTO;

public partial class LeaveBalanceDTO
{
    public int Id { get; set; }

    public string LeaveName { get; set; }

    public int BalanceDays { get; set; } 
    public string? EmployeeName { get; set; }
    public int EmployeeId { get; set; }
    //public EmployeeDTO? Employee { get; set; }

}

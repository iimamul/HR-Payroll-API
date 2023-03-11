using System;
using System.Collections.Generic;

namespace HR_Payroll_API.Entities;

public partial class LeaveBalance
{
    public int Id { get; set; }

    public string LeaveName { get; set; }

    public int BalanceDays { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}

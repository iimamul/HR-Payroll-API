using System;
using System.Collections.Generic;

namespace HR_Payroll_API.DTO;

public partial class LeaveBalanceDTO
{
    public int Id { get; set; }

    public string? LeaveName { get; set; }

    public int? BalanceDays { get; set; }

}

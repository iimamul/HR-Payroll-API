using AutoMapper;
using HR_Payroll_API.DTO;
using HR_Payroll_API.Entities;

namespace dotNetWithMySqlAPI.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveBalance, LeaveBalanceDTO>();
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}

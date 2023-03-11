using AutoMapper;
using HR_Payroll_API.DTO;
using HR_Payroll_API.Entities;

namespace dotNetWithMySqlAPI.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<LeaveBalanceDTO, LeaveBalance>()
                .ForMember(dest => dest.Employee, opt => opt.Ignore());

            CreateMap<LeaveBalance, LeaveBalanceDTO>()
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.EmployeeName))
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Employee.Id));
        }
    }
}

using AutoMapper;
using HR.Leavemanagement.Application.DTOS.LeaveAllocationDtos;
using HR.Leavemanagement.Application.DTOS.LeaveRequestDtos;
using HR.Leavemanagement.Application.DTOS.LeaveTypeDtos;
using HR.Leavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Profiles
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}

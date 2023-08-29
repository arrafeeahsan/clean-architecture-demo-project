using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveTypeRepository : IGenricRepository<LeaveType>
    {
        Task<LeaveType> GetLeaveTypeWithDetails(int id);
        Task<List<LeaveType>> GetLeaveTypeWithDetails();
    }
}

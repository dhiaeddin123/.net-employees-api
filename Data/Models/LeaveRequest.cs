using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blockchain_api.Data.Models
{
    public enum LeaveType
    {
        Annual,
        Sick,
        Other
    }

    public enum LeaveRequestStatus
    {
        Approved,
        Rejected,
        Pending
    }

    public class LeaveRequest
    {
        public int Id { get; set; }

        public LeaveType LeaveType { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public LeaveRequestStatus Status { get; set; }

        public string? Reason { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
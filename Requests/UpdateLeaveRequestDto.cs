using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using blockchain_api.Data.Models;

namespace blockchain_api.Requests
{
    public class UpdateLeaveRequestDto
    {
        public int? EmployeeId { get; set; }  // Nullable
        
        [EnumDataType(typeof(LeaveType))]  // Ensures it's a valid LeaveType
        public LeaveType? LeaveType { get; set; }  // Nullable
        public DateOnly? StartDate { get; set; }  // Nullable
        public DateOnly? EndDate { get; set; }  // Nullable
        public string? Reason { get; set; }  // Nullable
        
        [EnumDataType(typeof(LeaveRequestStatus))]  // Ensures it's a valid Status
        public LeaveRequestStatus? Status { get; set; }
    }
}
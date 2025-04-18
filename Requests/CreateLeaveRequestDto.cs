using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using blockchain_api.Data.Models;

namespace blockchain_api.Requests
{
    public class CreateLeaveRequestDto
    {
        public int EmployeeId { get; set; }
        
        [EnumDataType(typeof(LeaveType))]  // Ensures it's a valid LeaveType
        public LeaveType LeaveType { get; set; }

        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string Reason { get; set; }

    }
}
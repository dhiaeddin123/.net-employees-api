using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace blockchain_api.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string? Department { get; set; }

        public DateOnly JoiningDate { get; set; }

        [JsonIgnore]
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
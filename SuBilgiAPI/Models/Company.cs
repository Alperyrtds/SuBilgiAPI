using System;
using System.Collections.Generic;

#nullable disable

namespace SuBilgiAPI.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Owner { get; set; }
        public string VizeStartDate { get; set; }
        public string VizeEndDate { get; set; }
        public int? OwnerPhone { get; set; }
        public bool? Status { get; set; }
        public string CompanyPerformance { get; set; }
        public string FirstTimeThrottle { get; set; }
    }
}

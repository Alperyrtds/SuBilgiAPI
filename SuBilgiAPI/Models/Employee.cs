using System;
using System.Collections.Generic;

#nullable disable

namespace SuBilgiAPI.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
    }
}

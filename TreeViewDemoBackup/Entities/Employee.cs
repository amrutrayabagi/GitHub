using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeViewDemo.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public int? MgrEmployeeId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Course_Id { get; set; }
        public DateTime Enrollment_Date {get; set;}
        public int Course_Status { get; set; }
        public string Grade { get; set; }
    }
}

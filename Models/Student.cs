using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add these sections and current time.-->  
    }
}

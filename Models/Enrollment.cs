namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; } //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add get, set, for code.-->  

    }
}
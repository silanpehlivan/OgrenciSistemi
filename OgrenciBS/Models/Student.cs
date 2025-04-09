namespace OgrenciBS.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Gpa { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}

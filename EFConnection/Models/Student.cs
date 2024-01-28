namespace EFConnection.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Grade { get; set; }
        public int InFacultyId { get; set; }
        public Faculty InFaculty { get; set; }
        public List<StudentMark> Marks { get; set; }
    }
}

namespace EFConnection.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public Faculty InFaculty { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}

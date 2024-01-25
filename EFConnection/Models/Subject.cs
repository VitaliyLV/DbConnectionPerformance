namespace EFConnection.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProfessorId { get; set; }
        public Teacher Professor { get; set; }
    }
}

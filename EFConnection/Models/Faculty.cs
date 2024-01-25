namespace EFConnection.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Points { get; set; }
        public int HeadId { get; set; }
        public Teacher Head { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}

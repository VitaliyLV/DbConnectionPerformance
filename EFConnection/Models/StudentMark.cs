using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFConnection.Models
{
    public class StudentMark
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student StudentNavigation { get; set; }
        public int SubjectId { get; set; }
        public Subject SubjectNavigation { get; set; }
        public int TotalScore { get; set; }
    }
}

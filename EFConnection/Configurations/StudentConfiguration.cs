using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFConnection.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student { Id = 1, FirstName = "Harry", LastName = "Potter", Grade = 4, InFacultyId = 1 },
                new Student { Id = 2, FirstName = "Ron", LastName = "Weasley", Grade = 4, InFacultyId = 1 },
                new Student { Id = 3, FirstName = "Hermione", LastName = "Granger", Grade = 4, InFacultyId = 1 },
                new Student { Id = 4, FirstName = "Colin", LastName = "Creevey", Grade = 2, InFacultyId = 1 },
                new Student { Id = 5, FirstName = "Hannah", LastName = "Abbott", Grade = 3, InFacultyId = 2 },
                new Student { Id = 6, FirstName = "Ernie", LastName = "Macmillan", Grade = 1, InFacultyId = 2 },
                new Student { Id = 7, FirstName = "Vincent", LastName = "Crabbe", Grade = 4, InFacultyId = 4 },
                new Student { Id = 8, FirstName = "Gregory", LastName = "Goyle", Grade = 4, InFacultyId = 4 },
                new Student { Id = 9, FirstName = "Cho", LastName = "Chang", Grade = 3, InFacultyId = 3 },
                new Student { Id = 10, FirstName = "Padma", LastName = "Patil", Grade = 3, InFacultyId = 3 }
                
           );
        }
    }
}

using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFConnection.Configurations
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
                new Subject { Id = 1, Name= "Defence Against the Dark Arts", ProfessorId = 3 },
                new Subject { Id = 2, Name = "Transfiguration", ProfessorId = 2 },
                new Subject { Id = 3, Name = "Potions", ProfessorId = 5 },
                new Subject { Id = 4, Name= "Herbology", ProfessorId = 6 },
                new Subject { Id = 5, Name = "Charms", ProfessorId = 4 }
                );
        }
    }
}

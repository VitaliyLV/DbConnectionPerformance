using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFConnection.Configurations
{
    internal class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasData(
                new Faculty { Id = 1, Name = "Gryffindor", HeadId = 2 },
                new Faculty { Id = 2, Name = "Ravenclaw", HeadId = 4 },
                new Faculty { Id = 3, Name = "Hufflepuff", HeadId = 6 },
                new Faculty { Id = 4, Name = "Slytherin", HeadId = 5 }
                );
        }
    }
}

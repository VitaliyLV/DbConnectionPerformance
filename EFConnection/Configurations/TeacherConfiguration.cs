using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFConnection.Configurations
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(
                new Teacher { Id = 1, FirstName = "Albus", LastName = "Dumbledore" },
                new Teacher { Id = 2, FirstName = "Minerva", LastName = "McGonagall" },
                new Teacher { Id = 3, FirstName = "Alastor", LastName = "Moody" },
                new Teacher { Id = 4, FirstName = "Filius", LastName = "Flitwick" },
                new Teacher { Id = 5, FirstName = "Severus", LastName = "Snape" },
                new Teacher { Id = 6, FirstName = "Pomona", LastName = "Sprout" }
                );
        }
    }
}

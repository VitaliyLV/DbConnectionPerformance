using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFConnection.Configurations
{
    public class MarkConfiguration : IEntityTypeConfiguration<StudentMark>
    {
        public void Configure(EntityTypeBuilder<StudentMark> builder)
        {
            builder.HasOne(e => e.SubjectNavigation).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new StudentMark { Id = 1, StudentId = 1, SubjectId = 1, TotalScore = 10 },
                new StudentMark { Id = 2, StudentId = 1, SubjectId = 2, TotalScore = 5 },
                new StudentMark { Id = 3, StudentId = 1, SubjectId = 3, TotalScore = 4 },
                new StudentMark { Id = 4, StudentId = 2, SubjectId = 1, TotalScore = 8 },
                new StudentMark { Id = 5, StudentId = 2, SubjectId = 2, TotalScore = 6 },
                new StudentMark { Id = 6, StudentId = 2, SubjectId = 3, TotalScore = 5 },
                new StudentMark { Id = 7, StudentId = 3, SubjectId = 1, TotalScore = 10 },
                new StudentMark { Id = 8, StudentId = 3, SubjectId = 2, TotalScore = 12 },
                new StudentMark { Id = 9, StudentId = 3, SubjectId = 3, TotalScore = 12 },

                new StudentMark { Id = 10, StudentId = 4, SubjectId = 3, TotalScore = 8 },
                new StudentMark { Id = 11, StudentId = 4, SubjectId = 4, TotalScore = 8 },
                new StudentMark { Id = 12, StudentId = 4, SubjectId = 5, TotalScore = 7 },
                new StudentMark { Id = 13, StudentId = 5, SubjectId = 1, TotalScore = 10 },
                new StudentMark { Id = 14, StudentId = 5, SubjectId = 4, TotalScore = 5 },
                new StudentMark { Id = 15, StudentId = 5, SubjectId = 5, TotalScore = 11 }
                );
        }
    }
}

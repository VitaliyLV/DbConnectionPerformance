﻿// <auto-generated />
using EFConnection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFConnection.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240128183250_AddMarks")]
    partial class AddMarks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFConnection.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HeadId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeadId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HeadId = 2,
                            Name = "Gryffindor",
                            Points = 0
                        },
                        new
                        {
                            Id = 2,
                            HeadId = 4,
                            Name = "Ravenclaw",
                            Points = 0
                        },
                        new
                        {
                            Id = 3,
                            HeadId = 6,
                            Name = "Hufflepuff",
                            Points = 0
                        },
                        new
                        {
                            Id = 4,
                            HeadId = 5,
                            Name = "Slytherin",
                            Points = 0
                        });
                });

            modelBuilder.Entity("EFConnection.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("InFacultyId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("InFacultyId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Harry",
                            Grade = 4,
                            InFacultyId = 1,
                            LastName = "Potter"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ron",
                            Grade = 4,
                            InFacultyId = 1,
                            LastName = "Weasley"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Hermione",
                            Grade = 4,
                            InFacultyId = 1,
                            LastName = "Granger"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Colin",
                            Grade = 2,
                            InFacultyId = 1,
                            LastName = "Creevey"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Hannah",
                            Grade = 3,
                            InFacultyId = 2,
                            LastName = "Abbott"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Ernie",
                            Grade = 1,
                            InFacultyId = 2,
                            LastName = "Macmillan"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Vincent",
                            Grade = 4,
                            InFacultyId = 4,
                            LastName = "Crabbe"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Gregory",
                            Grade = 4,
                            InFacultyId = 4,
                            LastName = "Goyle"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Cho",
                            Grade = 3,
                            InFacultyId = 3,
                            LastName = "Chang"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Padma",
                            Grade = 3,
                            InFacultyId = 3,
                            LastName = "Patil"
                        });
                });

            modelBuilder.Entity("EFConnection.Models.StudentMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentMarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StudentId = 1,
                            SubjectId = 1,
                            TotalScore = 10
                        },
                        new
                        {
                            Id = 2,
                            StudentId = 1,
                            SubjectId = 2,
                            TotalScore = 5
                        },
                        new
                        {
                            Id = 3,
                            StudentId = 1,
                            SubjectId = 3,
                            TotalScore = 4
                        },
                        new
                        {
                            Id = 4,
                            StudentId = 2,
                            SubjectId = 1,
                            TotalScore = 8
                        },
                        new
                        {
                            Id = 5,
                            StudentId = 2,
                            SubjectId = 2,
                            TotalScore = 6
                        },
                        new
                        {
                            Id = 6,
                            StudentId = 2,
                            SubjectId = 3,
                            TotalScore = 5
                        },
                        new
                        {
                            Id = 7,
                            StudentId = 3,
                            SubjectId = 1,
                            TotalScore = 10
                        },
                        new
                        {
                            Id = 8,
                            StudentId = 3,
                            SubjectId = 2,
                            TotalScore = 12
                        },
                        new
                        {
                            Id = 9,
                            StudentId = 3,
                            SubjectId = 3,
                            TotalScore = 12
                        },
                        new
                        {
                            Id = 10,
                            StudentId = 4,
                            SubjectId = 3,
                            TotalScore = 8
                        },
                        new
                        {
                            Id = 11,
                            StudentId = 4,
                            SubjectId = 4,
                            TotalScore = 8
                        },
                        new
                        {
                            Id = 12,
                            StudentId = 4,
                            SubjectId = 5,
                            TotalScore = 7
                        },
                        new
                        {
                            Id = 13,
                            StudentId = 5,
                            SubjectId = 1,
                            TotalScore = 10
                        },
                        new
                        {
                            Id = 14,
                            StudentId = 5,
                            SubjectId = 4,
                            TotalScore = 5
                        },
                        new
                        {
                            Id = 15,
                            StudentId = 5,
                            SubjectId = 5,
                            TotalScore = 11
                        },
                        new
                        {
                            Id = 16,
                            StudentId = 6,
                            SubjectId = 1,
                            TotalScore = 6
                        },
                        new
                        {
                            Id = 17,
                            StudentId = 6,
                            SubjectId = 4,
                            TotalScore = 2
                        },
                        new
                        {
                            Id = 18,
                            StudentId = 7,
                            SubjectId = 5,
                            TotalScore = 7
                        },
                        new
                        {
                            Id = 19,
                            StudentId = 7,
                            SubjectId = 1,
                            TotalScore = 4
                        },
                        new
                        {
                            Id = 20,
                            StudentId = 8,
                            SubjectId = 4,
                            TotalScore = 5
                        },
                        new
                        {
                            Id = 21,
                            StudentId = 8,
                            SubjectId = 5,
                            TotalScore = 9
                        });
                });

            modelBuilder.Entity("EFConnection.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Defence Against the Dark Arts",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "Transfiguration",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Potions",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 4,
                            Name = "Herbology",
                            ProfessorId = 6
                        },
                        new
                        {
                            Id = 5,
                            Name = "Charms",
                            ProfessorId = 4
                        });
                });

            modelBuilder.Entity("EFConnection.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Albus",
                            LastName = "Dumbledore"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Minerva",
                            LastName = "McGonagall"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Alastor",
                            LastName = "Moody"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Filius",
                            LastName = "Flitwick"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Severus",
                            LastName = "Snape"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Pomona",
                            LastName = "Sprout"
                        });
                });

            modelBuilder.Entity("EFConnection.Models.Faculty", b =>
                {
                    b.HasOne("EFConnection.Models.Teacher", "Head")
                        .WithMany()
                        .HasForeignKey("HeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Head");
                });

            modelBuilder.Entity("EFConnection.Models.Student", b =>
                {
                    b.HasOne("EFConnection.Models.Faculty", "InFaculty")
                        .WithMany()
                        .HasForeignKey("InFacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InFaculty");
                });

            modelBuilder.Entity("EFConnection.Models.StudentMark", b =>
                {
                    b.HasOne("EFConnection.Models.Student", "StudentNavigation")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFConnection.Models.Subject", "SubjectNavigation")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("StudentNavigation");

                    b.Navigation("SubjectNavigation");
                });

            modelBuilder.Entity("EFConnection.Models.Subject", b =>
                {
                    b.HasOne("EFConnection.Models.Teacher", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EFConnection.Models.Student", b =>
                {
                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}

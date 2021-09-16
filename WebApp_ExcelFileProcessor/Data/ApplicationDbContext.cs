using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var hasher = new PasswordHasher<IdentityUser>();

            //  Gender
            builder.Entity<Gender>().HasData(
                new Gender
                {
                    GenderId = Guid.NewGuid(),
                    GenderName = "Female",
                    GenderChar = 'F',
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new Gender
                {
                    GenderId = Guid.NewGuid(),
                    GenderName = "Male",
                    GenderChar = 'M',
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                }
            );
            //  Student Color
            builder.Entity<StudentColor>().HasData(
                new StudentColor
                {
                    StudentColorId = Guid.NewGuid(),
                    ColorName = "Gold",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentColor
                {
                    StudentColorId = Guid.NewGuid(),
                    ColorName = "Scarlet",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentColor
                {
                    StudentColorId = Guid.NewGuid(),
                    ColorName = "Unassigned",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                }
               );
            //  Student Class
            builder.Entity<StudentClass>().HasData(
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'A',
                    DisplayName = "8A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'B',
                    DisplayName = "8B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'C',
                    DisplayName = "8C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'D',
                    DisplayName = "8D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'E',
                    DisplayName = "8E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'F',
                    DisplayName = "8F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'G',
                    DisplayName = "8G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'A',
                    DisplayName = "9A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'B',
                    DisplayName = "9B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'C',
                    DisplayName = "9C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'D',
                    DisplayName = "9D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'E',
                    DisplayName = "9E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'F',
                    DisplayName = "9F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'G',
                    DisplayName = "9G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'A',
                    DisplayName = "10A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'B',
                    DisplayName = "10B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'C',
                    DisplayName = "10C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'D',
                    DisplayName = "10D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'E',
                    DisplayName = "10E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'F',
                    DisplayName = "10F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'G',
                    DisplayName = "10G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'A',
                    DisplayName = "11A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'B',
                    DisplayName = "11B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'C',
                    DisplayName = "11C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'D',
                    DisplayName = "11D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'E',
                    DisplayName = "11E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'F',
                    DisplayName = "11F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'G',
                    DisplayName = "11G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'A',
                    DisplayName = "12A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'B',
                    DisplayName = "12B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'C',
                    DisplayName = "12C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'D',
                    DisplayName = "12D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'E',
                    DisplayName = "12E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'F',
                    DisplayName = "12F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'G',
                    DisplayName = "12G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                }
                );
            //  Student Group
            builder.Entity<StudentGroup>().HasData(
                new StudentGroup
                {
                    StudentGroupId = Guid.NewGuid(),
                    GroupChar = 'G',
                    GroupInt = 1,
                    DisplayName = "G1",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentGroup
                {
                    StudentGroupId = Guid.NewGuid(),
                    GroupChar = 'G',
                    GroupInt = 2,
                    DisplayName = "G2",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentGroup
                {
                    StudentGroupId = Guid.NewGuid(),
                    GroupChar = 'G',
                    GroupInt = 3,
                    DisplayName = "G3",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentGroup
                {
                    StudentGroupId = Guid.NewGuid(),
                    GroupChar = 'G',
                    GroupInt = 4,
                    DisplayName = "G4",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentGroup
                {
                    StudentGroupId = Guid.NewGuid(),
                    GroupChar = 'G',
                    GroupInt = 5,
                    DisplayName = "G5",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                }
                );
            //  Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                    Name = "Administrator",
                    NormalizedName = "Administrator".ToUpper()
                }
                );
            //  Users
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                    UserName = "myuser",
                    NormalizedUserName = "myuser".ToUpper(),
                    Email = "admin@fileprocessor.co.za",
                    NormalizedEmail = "admin@fileprocessor.co.za".ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumber = "0413743172",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123#@!Password")
                }
                ); ;
            //  User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                    UserId = "1b824f5d-01b1-411b-8e44-5b05003ef81e"
                }
                );
        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentColor> StudentColors { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentTemp> StudentTemps { get; set; }
        public DbSet<StudentScreeningTemp> StudentScreeningTemps { get; set; }
        public DbSet<StudentScreening> StudentScreenings { get; set; }
    }
}
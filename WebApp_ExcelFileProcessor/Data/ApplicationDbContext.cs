using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using WebApp_ExcelFileProcessor.Helpers;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
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
            //  Module Codes
            builder.Entity<ModuleCode>().HasData(
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "BASE".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "MML".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "LHC".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "AGCLM".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "ABCP".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "ENG".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "AFR/XHO".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "LO".ToUpper()
                },
                new ModuleCode
                {
                    ModuleCodeId = Guid.NewGuid(),
                    IsDeleted = false,
                    DateCreated = DateTime.Now,
                    ModuleCodeName = "EXAM".ToUpper()
                }
                );
        }

        // This is overridden to prevent someone from calling SaveChanges without specifying the user making the change
        public override int SaveChanges()
        {
            try
            {
                //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                //OnBeforeSaveChanges(userId);
                var result = base.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        #region Audit

        private void OnBeforeSaveChanges(string userId)
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Audit || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;
                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = userId;
                auditEntries.Add(auditEntry);
                foreach (var property in entry.Properties)
                {
                    string propertyName = property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[propertyName] = property.CurrentValue;
                            break;

                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[propertyName] = property.OriginalValue;
                            break;

                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(propertyName);
                                auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                            }
                            break;
                    }
                }
            }
            foreach (var auditEntry in auditEntries)
            {
                Audits.Add(auditEntry.ToAudit());
            }
        }

        #endregion Audit

        #region DbSets

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentColor> StudentColors { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentTemp> StudentTemps { get; set; }
        public DbSet<StudentScreeningTemp> StudentScreeningTemps { get; set; }
        public DbSet<StudentScreening> StudentScreenings { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<ModuleCode> ModuleCodes { get; set; }
        public DbSet<GradeModuleRoster> GradeModuleRoster { get; set; }

        #endregion DbSets
    }
}
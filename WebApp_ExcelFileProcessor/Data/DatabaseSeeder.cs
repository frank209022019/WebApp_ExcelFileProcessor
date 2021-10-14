using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.Data
{
    public class DatabaseSeeder
    {
        private static ApplicationDbContext _context;

        public static void SeedData(ApplicationDbContext context)
        {
            _context = context;
            SeedGenders();
            SeedClasses();
            SeedGroups();
            SeedUserData();
            SeedModuleCodes();
            SeedModuleRoster();
            _context.SaveChanges();
        }

        private static void SeedGenders()
        {
            if (_context.Genders.Count() > 0)
                return;

            List<Gender> list = new List<Gender>
            {
                      new Gender()
             {
                 GenderId = Guid.NewGuid(),
                 GenderName = "Female",
                 GenderChar = 'F',
                 IsDeleted = false,
                 DateCreated = DateTime.Now
             },
                      new Gender()
             {
                 GenderId = Guid.NewGuid(),
                 GenderName = "Male",
                 GenderChar = 'M',
                 IsDeleted = false,
                 DateCreated = DateTime.Now
             }
            };
            _context.Genders.AddRange(list);
        }

        private static void SeedClasses()
        {
            if (_context.StudentClasses.Count() > 0)
                return;

            List<StudentClass> list = new List<StudentClass>
            {
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'A',
                    DisplayName = "8A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'B',
                    DisplayName = "8B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'C',
                    DisplayName = "8C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'D',
                    DisplayName = "8D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'E',
                    DisplayName = "8E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'F',
                    DisplayName = "8F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 8,
                    ClassChar = 'G',
                    DisplayName = "8G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'A',
                    DisplayName = "9A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'B',
                    DisplayName = "9B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'C',
                    DisplayName = "9C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'D',
                    DisplayName = "9D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'E',
                    DisplayName = "9E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'F',
                    DisplayName = "9F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 9,
                    ClassChar = 'G',
                    DisplayName = "9G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'A',
                    DisplayName = "10A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'B',
                    DisplayName = "10B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'C',
                    DisplayName = "10C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'D',
                    DisplayName = "10D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'E',
                    DisplayName = "10E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'F',
                    DisplayName = "10F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 10,
                    ClassChar = 'G',
                    DisplayName = "10G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'A',
                    DisplayName = "11A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'B',
                    DisplayName = "11B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'C',
                    DisplayName = "11C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'D',
                    DisplayName = "11D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'E',
                    DisplayName = "11E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'F',
                    DisplayName = "11F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 11,
                    ClassChar = 'G',
                    DisplayName = "11G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'A',
                    DisplayName = "12A",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'B',
                    DisplayName = "12B",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'C',
                    DisplayName = "12C",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'D',
                    DisplayName = "12D",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'E',
                    DisplayName = "12E",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'F',
                    DisplayName = "12F",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                },
                new StudentClass()
                {
                    StudentClassId = Guid.NewGuid(),
                    GradeInt = 12,
                    ClassChar = 'G',
                    DisplayName = "12G",
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                }
            };
            _context.StudentClasses.AddRange(list);
        }

        private static void SeedGroups()
        {
            if (_context.StudentGroups.Count() > 0)
                return;

            List<StudentGroup> list = new List<StudentGroup>
            {
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
            };
            _context.StudentGroups.AddRange(list);
        }

        private static void SeedUserData()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            if (_context.Roles.Count() > 0)
                return;

            _context.Roles.Add(
               new IdentityRole
               {
                   Id = "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                   Name = "Administrator",
                   NormalizedName = "Administrator".ToUpper()
               });

            if (_context.Users.Count() > 0)
                return;

            _context.Users.Add(
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
                );

            if (_context.UserRoles.Count() > 0)
                return;

            _context.UserRoles.Add(
                  new IdentityUserRole<string>
                  {
                      RoleId = "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                      UserId = "1b824f5d-01b1-411b-8e44-5b05003ef81e"
                  }
                );
        }

        private static void SeedModuleCodes()
        {
            if (_context.ModuleCodes.Count() > 0)
                return;

            List<ModuleCode> list = new List<ModuleCode>
            {
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
            };
            _context.ModuleCodes.AddRange(list);
        }

        private static void SeedModuleRoster()
        {
            if (_context.GradeModuleRoster.Count() > 0)
                return;

            var moduleCodes = _context.ModuleCodes.ToList();

            List<GradeModuleRoster> list = new List<GradeModuleRoster>()
            {
                //  grade 8
                    new GradeModuleRoster
                    {
                        GradeModuleRosterId = Guid.NewGuid(),
                        DateCreated = DateTime.Now,
                        IsDeleted = false,
                        DayOfWeek = DayOfWeek.Monday,
                        GradeInt = 8,
                        ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                    },
                     new GradeModuleRoster
                     {
                            GradeModuleRosterId = Guid.NewGuid(),
                         DateCreated = DateTime.Now,
                         IsDeleted = false,
                         DayOfWeek = DayOfWeek.Tuesday,
                         GradeInt = 8,
                         ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                     },
                      new GradeModuleRoster
                      {
                             GradeModuleRosterId = Guid.NewGuid(),
                          DateCreated = DateTime.Now,
                          IsDeleted = false,
                          DayOfWeek = DayOfWeek.Wednesday,
                          GradeInt = 8,
                          ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AFR/XHO").ModuleCodeId
                      },
                       new GradeModuleRoster
                       {
                              GradeModuleRosterId = Guid.NewGuid(),
                           DateCreated = DateTime.Now,
                           IsDeleted = false,
                           DayOfWeek = DayOfWeek.Thursday,
                           GradeInt = 8,
                           ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                       },
                        new GradeModuleRoster
                        {
                               GradeModuleRosterId = Guid.NewGuid(),
                            DateCreated = DateTime.Now,
                            IsDeleted = false,
                            DayOfWeek = DayOfWeek.Friday,
                            GradeInt = 8,
                            ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                        },
                         // grade 9
                         new GradeModuleRoster
                         {
                                GradeModuleRosterId = Guid.NewGuid(),
                             DateCreated = DateTime.Now,
                             IsDeleted = false,
                             DayOfWeek = DayOfWeek.Monday,
                             GradeInt = 9,
                             ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                         },
                     new GradeModuleRoster
                     {
                            GradeModuleRosterId = Guid.NewGuid(),
                         DateCreated = DateTime.Now,
                         IsDeleted = false,
                         DayOfWeek = DayOfWeek.Tuesday,
                         GradeInt = 9,
                         ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                     },
                      new GradeModuleRoster
                      {
                             GradeModuleRosterId = Guid.NewGuid(),
                          DateCreated = DateTime.Now,
                          IsDeleted = false,
                          DayOfWeek = DayOfWeek.Wednesday,
                          GradeInt = 9,
                          ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AFR/XHO").ModuleCodeId
                      },
                       new GradeModuleRoster
                       {
                              GradeModuleRosterId = Guid.NewGuid(),
                           DateCreated = DateTime.Now,
                           IsDeleted = false,
                           DayOfWeek = DayOfWeek.Thursday,
                           GradeInt = 9,
                           ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AFR/XHO").ModuleCodeId
                       },
                        new GradeModuleRoster
                        {
                            GradeModuleRosterId = Guid.NewGuid(),
                            DateCreated = DateTime.Now,
                            IsDeleted = false,
                            DayOfWeek = DayOfWeek.Friday,
                            GradeInt = 9,
                            ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "BASE").ModuleCodeId
                        },
                              //grade 10
                              new GradeModuleRoster
                              {
                                  GradeModuleRosterId = Guid.NewGuid(),
                                  DateCreated = DateTime.Now,
                                  IsDeleted = false,
                                  DayOfWeek = DayOfWeek.Monday,
                                  GradeInt = 10,
                                  ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "LHC").ModuleCodeId
                              },
                             new GradeModuleRoster
                             {
                                 GradeModuleRosterId = Guid.NewGuid(),
                                 DateCreated = DateTime.Now,
                                 IsDeleted = false,
                                 DayOfWeek = DayOfWeek.Tuesday,
                                 GradeInt = 10,
                                 ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "LHC").ModuleCodeId
                             },
                              new GradeModuleRoster
                              {
                                  GradeModuleRosterId = Guid.NewGuid(),
                                  DateCreated = DateTime.Now,
                                  IsDeleted = false,
                                  DayOfWeek = DayOfWeek.Wednesday,
                                  GradeInt = 10,
                                  ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "ENG").ModuleCodeId
                              },
                               new GradeModuleRoster
                               {
                                   GradeModuleRosterId = Guid.NewGuid(),
                                   DateCreated = DateTime.Now,
                                   IsDeleted = false,
                                   DayOfWeek = DayOfWeek.Thursday,
                                   GradeInt = 10,
                                   ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "MML").ModuleCodeId
                               },
                                new GradeModuleRoster
                                {
                                    GradeModuleRosterId = Guid.NewGuid(),
                                    DateCreated = DateTime.Now,
                                    IsDeleted = false,
                                    DayOfWeek = DayOfWeek.Friday,
                                    GradeInt = 10,
                                    ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "LHC").ModuleCodeId
                                },
                                         //grade 11
                                         new GradeModuleRoster
                                         {
                                             GradeModuleRosterId = Guid.NewGuid(),
                                             DateCreated = DateTime.Now,
                                             IsDeleted = false,
                                             DayOfWeek = DayOfWeek.Monday,
                                             GradeInt = 11,
                                             ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AGCLM").ModuleCodeId
                                         },
                                         new GradeModuleRoster
                                         {
                                             GradeModuleRosterId = Guid.NewGuid(),
                                             DateCreated = DateTime.Now,
                                             IsDeleted = false,
                                             DayOfWeek = DayOfWeek.Tuesday,
                                             GradeInt = 11,
                                             ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AGCLM").ModuleCodeId
                                         },
                                          new GradeModuleRoster
                                          {
                                              GradeModuleRosterId = Guid.NewGuid(),
                                              DateCreated = DateTime.Now,
                                              IsDeleted = false,
                                              DayOfWeek = DayOfWeek.Wednesday,
                                              GradeInt = 11,
                                              ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "ABCP").ModuleCodeId
                                          },
                                           new GradeModuleRoster
                                           {
                                               GradeModuleRosterId = Guid.NewGuid(),
                                               DateCreated = DateTime.Now,
                                               IsDeleted = false,
                                               DayOfWeek = DayOfWeek.Thursday,
                                               GradeInt = 11,
                                               ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "LHC").ModuleCodeId
                                           },
                                            new GradeModuleRoster
                                            {
                                                GradeModuleRosterId = Guid.NewGuid(),
                                                DateCreated = DateTime.Now,
                                                IsDeleted = false,
                                                DayOfWeek = DayOfWeek.Friday,
                                                GradeInt = 11,
                                                ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AFR/XHO").ModuleCodeId
                                            },
                                                 //  grade 12
                                                 new GradeModuleRoster
                                                 {
                                                     GradeModuleRosterId = Guid.NewGuid(),
                                                     DateCreated = DateTime.Now,
                                                     IsDeleted = false,
                                                     DayOfWeek = DayOfWeek.Monday,
                                                     GradeInt = 12,
                                                     ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "MML").ModuleCodeId
                                                 },
                                                 new GradeModuleRoster
                                                 {
                                                     GradeModuleRosterId = Guid.NewGuid(),
                                                     DateCreated = DateTime.Now,
                                                     IsDeleted = false,
                                                     DayOfWeek = DayOfWeek.Tuesday,
                                                     GradeInt = 12,
                                                     ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AFR/XHO").ModuleCodeId
                                                 },
                                                  new GradeModuleRoster
                                                  {
                                                      GradeModuleRosterId = Guid.NewGuid(),
                                                      DateCreated = DateTime.Now,
                                                      IsDeleted = false,
                                                      DayOfWeek = DayOfWeek.Wednesday,
                                                      GradeInt = 12,
                                                      ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AGCLM").ModuleCodeId
                                                  },
                                                   new GradeModuleRoster
                                                   {
                                                       GradeModuleRosterId = Guid.NewGuid(),
                                                       DateCreated = DateTime.Now,
                                                       IsDeleted = false,
                                                       DayOfWeek = DayOfWeek.Thursday,
                                                       GradeInt = 12,
                                                       ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "LO").ModuleCodeId
                                                   },
                                                    new GradeModuleRoster
                                                    {
                                                        GradeModuleRosterId = Guid.NewGuid(),
                                                        DateCreated = DateTime.Now,
                                                        IsDeleted = false,
                                                        DayOfWeek = DayOfWeek.Friday,
                                                        GradeInt = 12,
                                                        ModuleCodeId = moduleCodes.FirstOrDefault(i => !i.IsDeleted && i.ModuleCodeName.ToUpper() == "AGCLM").ModuleCodeId
                                                    }
            };
            _context.GradeModuleRoster.AddRange(list);
        }

    }
}

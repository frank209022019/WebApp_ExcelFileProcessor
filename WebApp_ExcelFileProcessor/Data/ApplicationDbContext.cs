using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        }

        #region Audit

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
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentTemp> StudentTemps { get; set; }
        public DbSet<StudentScreeningTemp> StudentScreeningTemps { get; set; }
        public DbSet<StudentScreening> StudentScreenings { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<ModuleCode> ModuleCodes { get; set; }
        public DbSet<GradeModuleRoster> GradeModuleRoster { get; set; }
        public DbSet<ExcelDownload> ExcelDownloads { get; set; }

        #endregion DbSets     
    }
}
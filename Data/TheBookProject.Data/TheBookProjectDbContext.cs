﻿namespace TheBookProject.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Common.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TheBookProjectDbContext : IdentityDbContext<User>
    {
        public TheBookProjectDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Book> Books { get; set; }

        public static TheBookProjectDbContext Create()
        {
            return new TheBookProjectDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}

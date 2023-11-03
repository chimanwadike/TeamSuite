using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Configurations;
using TeamSuite.Entities.Models;

namespace TeamSuite.Repository;

public class RepositoryContext : IdentityDbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Member> Members { get; set; }
    public DbSet<CheckListItem> CheckListItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new SiteConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new CheckListItemConfiguration());
    }
}

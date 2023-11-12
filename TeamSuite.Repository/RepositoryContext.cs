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

public class RepositoryContext : IdentityDbContext<ApplicationUser>
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Site> Sites { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<SubTeam> SubTeams { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<LookUp> LookUps { get; set; }
    public DbSet<CheckListForm> CheckListForms { get; set; }
    public DbSet<CheckListItem> CheckListItems { get; set; }
    public DbSet<CheckList> CheckLists { get; set; }
    public DbSet<CheckListReport> CheckListReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new SiteConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new CheckListItemConfiguration());
        modelBuilder.ApplyConfiguration(new CheckListFormConfiguration());
        modelBuilder.ApplyConfiguration(new CheckListConfiguration());
        modelBuilder.ApplyConfiguration(new LookUpConfiguration());

    }
}

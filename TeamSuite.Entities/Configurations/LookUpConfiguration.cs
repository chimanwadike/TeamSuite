using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Models;

namespace TeamSuite.Entities.Configurations
{
    public class LookUpConfiguration : IEntityTypeConfiguration<LookUp>
    {
        public void Configure(EntityTypeBuilder<LookUp> builder)
        {            
            
            builder.HasData(
                new LookUp { Id = Guid.Parse("25cf2e32-36fa-47fe-a272-6afc8bd95f5c"), Category = "checklist_status", Name = "Pending", Order = 1 },
                new LookUp { Id = Guid.Parse("9bf75416-d543-4cff-8c94-10c73d0862f1"), Category = "checklist_status", Name = "Success", Order = 2 },
                new LookUp { Id = Guid.Parse("62ae3adb-0603-4274-aea0-62952c3065f7"), Category = "checklist_status", Name = "Failure", Order = 3 });
        }
    }
}

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
                new LookUp { Id = Guid.NewGuid(), Category = "checklist_status", Name = "Pending", Order = 1 },
                new LookUp { Id = Guid.NewGuid(), Category = "checklist_status", Name = "Success", Order = 2 },
                new LookUp { Id = Guid.NewGuid(), Category = "checklist_status", Name = "Failure", Order = 3 });
        }
    }
}

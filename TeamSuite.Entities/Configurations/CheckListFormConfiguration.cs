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
    public class CheckListFormConfiguration : IEntityTypeConfiguration<CheckListForm>
    {
        public void Configure(EntityTypeBuilder<CheckListForm> builder)
        {
            builder.HasData(
                new CheckListForm { Id = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), Name = "Technical Team CheckList", Description = "Technical Services Management" }
                );
        }
    }
}

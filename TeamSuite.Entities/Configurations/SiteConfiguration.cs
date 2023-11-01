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
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.HasData(
                new Site { Id = Guid.NewGuid(), Name = "Graceland", Address = "Wumba, Apo" }, 
                new Site { Id = Guid.NewGuid(), Name = "Zoo Arena", Address = "Afri Hotel, CBD" }
                );
        }
    }
}

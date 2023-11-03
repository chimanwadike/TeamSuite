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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
               new Location { Id = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), SiteId = Guid.Parse("b6dda148-d324-4231-b578-f238d69fcfb8"), Name = "Server Room"},
               new Location { Id = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), SiteId = Guid.Parse("b6dda148-d324-4231-b578-f238d69fcfb8"), Name = "Tarmac" },
               new Location { Id = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), SiteId = Guid.Parse("b6dda148-d324-4231-b578-f238d69fcfb8"), Name = "IT Desk" }
               );
        }
    }
}

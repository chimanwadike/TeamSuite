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
    public class CheckListItemConfiguration : IEntityTypeConfiguration<CheckListItem>
    {
        public void Configure(EntityTypeBuilder<CheckListItem> builder)
        {
            builder.HasData(
                new CheckListItem { Id = Guid.Parse("a1dda148-d324-4231-b578-f238d69fcfb8"), Name = "Switch on Server" },
                new CheckListItem { Id = Guid.Parse("2886bc74-cb10-40fd-a1aa-d8fdff8da600"), Name = "Switch on Internet" },
                new CheckListItem { Id = Guid.Parse("d228aac6-b250-4624-851d-f5436e3ddfd0"), Name = "Switch on System for Intercom" },
                new CheckListItem { Id = Guid.Parse("323b892f-675c-4398-a522-fe236452b845"), Name = "Confirm Intercom Working (Call all lines)" },
                new CheckListItem { Id = Guid.Parse("4c211be7-08d2-40d6-aa53-c2fd45e44093"), Name = "Confirm Internet functioning" },

                new CheckListItem { Id = Guid.Parse("4d8e9047-5252-4b4d-a444-fd61bde84f30"), Name = "Switch on System(s)" },
                new CheckListItem { Id = Guid.Parse("8a7a6f0a-22d1-49ed-acac-5077ca1de851"), Name = "Confirm internet on System(s)" },
                new CheckListItem { Id = Guid.Parse("1f697cf5-88d4-4540-bc12-cc0a7fb4a4b4"), Name = "Switch on TV" },
                new CheckListItem { Id = Guid.Parse("f7e3ba90-7bec-4a7a-b13f-546cc47bdc8d"), Name = "Switch on CCTV" },
                new CheckListItem { Id = Guid.Parse("700bbd8f-ed41-42a8-a05b-247b75e094a9"), Name = "Check Nursing Mothers Room for feed" },
                new CheckListItem { Id = Guid.Parse("2cdad48a-0eb7-427d-85be-06b5b3ea79e1"), Name = "Check System Storage Space" },
                new CheckListItem { Id = Guid.Parse("cbda2593-663c-4d1d-8fa7-fdfff22ec4ef"), Name = "Confirm Sound from Epignosis" },
                new CheckListItem { Id = Guid.Parse("ee3994db-db07-4777-b1f8-ee73dc2fdc9e"), Name = "Confirm Sound from Main Church" },
                new CheckListItem { Id = Guid.Parse("5b9b97a8-e9b9-4ec2-9b22-a73cd7aae21f"), Name = "Confirm Feed form Broadcast" },
                new CheckListItem { Id = Guid.Parse("1ee4d6f9-543f-4e82-bfee-4fb5fbae2e76"), Name = "Confirm Feed and Sound to Streaming Booth" },
                
                new CheckListItem { Id = Guid.Parse("86561683-ea1b-4817-93d5-617465998a62"), Name = "Check System for Recording and Timer" },
                new CheckListItem { Id = Guid.Parse("ef4662de-f86f-4c61-ae5b-d08554ebec16"), Name = "Test Recording software" },
                new CheckListItem { Id = Guid.Parse("a5abdc33-7865-487e-928f-5ce5fcc80bb8"), Name = "Retrieve program for the Day" },
                new CheckListItem { Id = Guid.Parse("e7c7973f-1ec6-4745-88ed-011b3064046c"), Name = "Upload Program to System and share to TV" },
                new CheckListItem { Id = Guid.Parse("7358c6ff-0617-45d0-85a2-db13d0f92100"), Name = "Setup timer" },
                new CheckListItem { Id = Guid.Parse("6372e3ad-9a8c-44e1-bbf2-9de4c7f32f53"), Name = "Confirm Feed from Broadcast on Vmix" }

                );
        }
    }
}

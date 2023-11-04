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
    public class CheckListConfiguration : IEntityTypeConfiguration<CheckList>
    {
        public void Configure(EntityTypeBuilder<CheckList> builder)
        {
            builder.HasData(
            new CheckList { Id = Guid.Parse("ae41afcb-2cfa-445d-9be0-de741b33f86a"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("a1dda148-d324-4231-b578-f238d69fcfb8"), Order = 1},
            new CheckList { Id = Guid.Parse("d85eda40-0b43-407e-80e1-e4b28be86fd2"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("2886bc74-cb10-40fd-a1aa-d8fdff8da600"), Order = 2 },
            new CheckList { Id = Guid.Parse("1989a2dd-82d6-488e-a29e-cbdfeb5b18dc"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("d228aac6-b250-4624-851d-f5436e3ddfd0"), Order = 3 },
            new CheckList { Id = Guid.Parse("e52c85b4-8ee9-4d25-ad63-8c386de8734b"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("323b892f-675c-4398-a522-fe236452b845"), Order = 4 },
            new CheckList { Id = Guid.Parse("0fdadf87-a6ef-4c77-adbb-29cf9f621513"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("03164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("4c211be7-08d2-40d6-aa53-c2fd45e44093"), Order = 5 },
            new CheckList { Id = Guid.Parse("4f4acce2-9c26-4cce-bbd8-48ab28246e8c"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("4d8e9047-5252-4b4d-a444-fd61bde84f30"), Order = 6 },
            new CheckList { Id = Guid.Parse("f3b77dd2-e03a-4c07-8391-75c01513da68"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("8a7a6f0a-22d1-49ed-acac-5077ca1de851"), Order = 7 },
            new CheckList { Id = Guid.Parse("42db7a66-078a-4501-bcc5-f22a73c0f7a8"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("1f697cf5-88d4-4540-bc12-cc0a7fb4a4b4"), Order = 8 },
            new CheckList { Id = Guid.Parse("eb7c46b1-87c6-4c73-9c80-b1b1486c2ba1"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("f7e3ba90-7bec-4a7a-b13f-546cc47bdc8d"), Order = 9 },
            new CheckList { Id = Guid.Parse("6dcc9fdb-f969-4f2c-82ba-6911fd6e4476"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("700bbd8f-ed41-42a8-a05b-247b75e094a9"), Order = 10 },
            new CheckList { Id = Guid.Parse("08903ef8-4b71-45da-b291-c39438d176cb"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("2cdad48a-0eb7-427d-85be-06b5b3ea79e1"), Order = 11 },
            new CheckList { Id = Guid.Parse("886788dd-0c1f-4432-b8e0-14ce92672e43"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("cbda2593-663c-4d1d-8fa7-fdfff22ec4ef"), Order = 12 },
            new CheckList { Id = Guid.Parse("51e5af57-b859-4e4b-add2-3dfcd257b042"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("ee3994db-db07-4777-b1f8-ee73dc2fdc9e"), Order = 13 },
            new CheckList { Id = Guid.Parse("35d216c1-9847-4fcc-8f90-48dd785ca18d"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("5b9b97a8-e9b9-4ec2-9b22-a73cd7aae21f"), Order = 14 },
            new CheckList { Id = Guid.Parse("47ca39fd-46e5-42ba-a33a-cdc38850af8b"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("13164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("1ee4d6f9-543f-4e82-bfee-4fb5fbae2e76"), Order = 15 },
            new CheckList { Id = Guid.Parse("9d52c8d7-baa4-4b0a-bd67-26ecc680f2e4"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("86561683-ea1b-4817-93d5-617465998a62"), Order = 16 },
            new CheckList { Id = Guid.Parse("8add9f01-b65b-49e3-afca-b87fdba89413"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("ef4662de-f86f-4c61-ae5b-d08554ebec16"), Order = 17 },
            new CheckList { Id = Guid.Parse("60086472-53d1-4c23-ae4b-19605550f191"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("a5abdc33-7865-487e-928f-5ce5fcc80bb8"), Order = 18 },
            new CheckList { Id = Guid.Parse("157aafe4-c388-4d0b-97da-5c0315982fc0"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("e7c7973f-1ec6-4745-88ed-011b3064046c"), Order = 19 },
            new CheckList { Id = Guid.Parse("3768dad2-a72b-4a07-8ffa-684c656a4802"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("7358c6ff-0617-45d0-85a2-db13d0f92100"), Order = 20 },
            new CheckList { Id = Guid.Parse("fe30ade3-bda3-4a99-9581-f28db009d206"), CheckListFormId = Guid.Parse("0ccacbc2-ca8a-426c-8461-e01047ec9765"), LocationId = Guid.Parse("23164e2a-7a90-11ee-b962-0242ac120002"), CheckListItemId = Guid.Parse("6372e3ad-9a8c-44e1-bbf2-9de4c7f32f53"), Order = 21 }
            );
        }
    }
}

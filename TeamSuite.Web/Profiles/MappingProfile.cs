using AutoMapper;
using TeamSuite.Entities.Models;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Web.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<CheckListReport, CheckListReportReadDTO>()
                .ForMember(_ => _.Action, source => source.MapFrom(_ => _.CheckList.CheckListItem.Name))
                .ForMember(_ => _.Location, source => source.MapFrom(_ => _.CheckList.Location.Name));
        }
    }
}

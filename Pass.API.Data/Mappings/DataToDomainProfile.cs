using AutoMapper;
using Pass.API.Business.Domain;
using Pass.API.Data.Models;
using System.Linq;

namespace Pass.API.Data.Mappings
{
    class DataToDomainProfile : Profile
    {
        public DataToDomainProfile()
        {
            CreateMap<BuildingEntity, Building>();

            CreateMap<EmployeeEntity, Employee>();

            CreateMap<VisitEntity, Visit>()
            .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.StatusNavigation))
            .ForMember(dest => dest.Building, opts => opts.MapFrom(src => src.BuildingNavigation))
            .ForMember(dest => dest.VisitedPerson, opts => opts.MapFrom(src => src.VisitedPersonNavigation))
            .ForMember(dest => dest.CreatedBy, opts => opts.MapFrom(src => src.CreatedByNavigation))
            .ForMember(dest => dest.Visitors, opts => opts.MapFrom(src => src.VisitVisitor.Select(vv => vv.VisitorNavigation)));

            CreateMap<VisitStatusEntity, VisitStatus>();
        }
    }
}

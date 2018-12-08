using AutoMapper;
using Pass.API.Business.Domain;
using Pass.API.Web.Models;

namespace Pass.API.Web.Mappings
{
    class DomainToApiProfile : Profile
    {
        public DomainToApiProfile()
        {
            CreateMap<BuildingDTO, Building>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<VisitDTO, Visit>();
            CreateMap<VisitStatusDTO, VisitStatus>();
        }
    }
}

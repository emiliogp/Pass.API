using AutoMapper;
using Pass.API.Business.Domain;
using Pass.API.Data.Models;

namespace Pass.API.Data.Mappings
{
    class DataToDomainProfile : Profile
    {
        public DataToDomainProfile()
        {
            CreateMap<BuildingEntity, Building>();
            CreateMap<EmployeeEntity, Employee>();
            CreateMap<VisitEntity, Visit>();
            CreateMap<VisitStatusEntity, VisitStatus>();
        }
    }
}

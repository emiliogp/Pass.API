using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pass.API.Business.Domain;
using Pass.API.Data.Models;
using Pass.API.Interfaces.Entities;
using Pass.API.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace Pass.API.Data.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private PassContext _context;
        private readonly IMapper _mapper;

        public VisitRepository(PassContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<IVisit> GetAll(int? count)
        {
            var visits = Includify(_context.Visit).Where(_ => true);
            if (count.HasValue)
            {
                visits = visits.Take(count.Value);
            }
            visits = visits.OrderBy(v => v.StartDate);

            return visits.Select(v => _mapper.Map<Visit>(v));
        }


        public IVisit GetById(int Id)
        {
            VisitEntity v = Includify(_context.Visit)
                .Where(vi => vi.Id == Id).FirstOrDefault();
            return _mapper.Map<Visit>(v);
        }

        private IQueryable<VisitEntity> Includify (IQueryable<VisitEntity> visitQuery)
        {
            return visitQuery.Include(vi => vi.StatusNavigation)
                .Include(vi => vi.BuildingNavigation)
                .Include(vi => vi.VisitedPersonNavigation)
                .Include(vi => vi.CreatedByNavigation)
                .Include(vi => vi.VisitVisitor)
                .ThenInclude(vv => vv.VisitorNavigation);
        }
    }
}

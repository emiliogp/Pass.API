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

        public IEnumerable<IVisit> GetAll()
        {
            List<Visit> Visits = new List<Visit>();
            foreach (VisitEntity v in _context.Visits)
            {
                Visits.Add(_mapper.Map<Visit>(v));                
            }

            return Visits;
        }


        public IVisit GetById(int Id)
        {
            VisitEntity v = _context.Visits.Include(vi => vi.Status).Where(vi => vi.Id == Id).FirstOrDefault();
            return _mapper.Map<Visit>(v);
        }
    }
}

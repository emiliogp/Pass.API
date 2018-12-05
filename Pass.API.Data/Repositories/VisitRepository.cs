using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Pass.API.Model;
using Pass.API.Interfaces.Repositories;
using Pass.API.Interfaces.Entities;
using Pass.API.Data.Models;


namespace Pass.API.Data.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private PassContext _context;

        public VisitRepository(PassContext context)
        {
            _context = context;
        }

        public IEnumerable<IEntity> GetAll()
        {
            List<VisitDTO> Visits = new List<VisitDTO>();
            foreach (Visit v in _context.Visit)
            {
                VisitDTO visit = new VisitDTO();

                VisitStatus vs = v.StatusNavigation;
                VisitStatusDTO visitStatus = new VisitStatusDTO();
                visitStatus.Id = vs.StatusKey;
                visitStatus.Name = vs.Name;

                visit.Id = v.VisitId;
                visit.Status = visitStatus;
                visit.StartDate = v.StartDate;
                visit.EndDate = v.EndDate;
                Visits.Add(visit);
            }

            return Visits;
        }


        public IEntity GetById(int Id)
        {
            Visit v = _context.Visit.Where(vi => vi.VisitId == Id).FirstOrDefault();
            VisitDTO visit = null;
            if (v != null)
            {
                VisitStatus vs = v.StatusNavigation;
                VisitStatusDTO visitStatus = new VisitStatusDTO();
                visitStatus.Id = vs.StatusKey;
                visitStatus.Name = vs.Name;

                visit.Id = v.VisitId;
                visit.Status = visitStatus;
                visit.StartDate = v.StartDate;
                visit.EndDate = v.EndDate;
            }

            return visit;
        }
    }
}

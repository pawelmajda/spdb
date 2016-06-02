using Simple.Data;
using SPDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.DataAccess
{
    public interface IIssueRepository
    {
        Issue GetIssueById(int issueId);
        IEnumerable<IssueCore> GetIssues(int limit = 0);
        int GetIssuesCount();
        IEnumerable<IssueCore> GetIssuesByState(int stateId, int limit = 0);
        int GetIssuesCountByState(int stateId);
        IEnumerable<IssueCore> GetIssuesByCounty(int countyId, int limit = 0);
        int GetIssuesCountByCounty(int countyId);
        IEnumerable<IssueCore> GetIssuesByPlace(int placeId, int limit = 0);
        int GetIssuesCountByPlace(int placeId);
    }

    class IssueRepository : IIssueRepository
    {
        private readonly dynamic _db = Database.Open();

        public Issue GetIssueById(int issueId)
        {
            return _db.Issues.FindById(issueId);
        }

        public IEnumerable<IssueCore> GetIssues(int limit = 0)
        {
            if(limit > 0)
            {
                return _db.Issues.All().OrderByCreatedTimeDescending().Take(limit);
            }
            else
            {
                return _db.Issues.All().OrderByCreatedTimeDescending();
            }
        }

        public int GetIssuesCount()
        {
            return _db.Issues.GetCount();
        }

        public IEnumerable<IssueCore> GetIssuesByState(int stateId, int limit = 0)
        {
            return _db.GetIssuesByState(stateId, limit);
        }

        public int GetIssuesCountByState(int stateId)
        {
            return _db.GetIssuesCountByState(stateId).FirstOrDefault().ToScalar();
        }

        public IEnumerable<IssueCore> GetIssuesByCounty(int countyId, int limit = 0)
        {
            return _db.GetIssuesByCounty(countyId, limit);
        }

        public int GetIssuesCountByCounty(int countyId)
        {
            return _db.GetIssuesCountByCounty(countyId).FirstOrDefault().ToScalar();
        }

        public IEnumerable<IssueCore> GetIssuesByPlace(int placeId, int limit = 0)
        {
            return _db.GetIssuesByPlace(placeId, limit);
        }

        public int GetIssuesCountByPlace(int placeId)
        {
            return _db.GetIssuesCountByPlace(placeId).FirstOrDefault().ToScalar();
        }
    }
}

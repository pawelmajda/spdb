using Simple.Data;
using SPDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.DataAccess
{
    public interface IStatesRepository
    {
        IEnumerable<State> GetAllStates();
    }

    class StatesRepository : IStatesRepository
    {
        private readonly dynamic _db = Database.Open();

        public IEnumerable<State> GetAllStates()
        {
            return _db.StateAdms.All().Select(_db.StateAdms.Id, _db.StateAdms.Name);
        }

    }
}

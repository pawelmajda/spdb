using Simple.Data;
using SPDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.DataAccess
{
    public interface IPlacesRepository
    {
        IEnumerable<Place> GetPlaces();
    }

    class PlacesRepository : IPlacesRepository
    {
        private readonly dynamic _db = Database.Open();

        public IEnumerable<Place> GetPlaces()
        {
            return _db.GetPlacesWithStats();
        }

    }
}

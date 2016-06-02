using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.Model
{
    public class PlaceCore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}

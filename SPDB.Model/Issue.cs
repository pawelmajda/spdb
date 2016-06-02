using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.Model
{
    public class Issue : IssueCore
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public int VotesCount { get; set; }
        public int CommentsCount { get; set; }
        public int ViewsCount { get; set; }
        public string Source { get; set; }
        public DateTime CreatedTime { get; set; }
        public string TypeTag { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB.Model
{
    public class Place : PlaceCore
    {
        public int TotalPop { get; set; }
        public int WhitePop { get; set; }
        public int BlackPop { get; set; }
        public int AsianPop { get; set; }
        public int IndianPop { get; set; }
        public int HawaiianPop { get; set; }
        public int OtherPop { get; set; }
        public int ForeignBornPop { get; set; }
        public float MedianAge { get; set; }
        public int CompaniesNum { get; set; }
        public float EducatedPercentage { get; set; }
        public float PoorPercentage { get; set; }
        public int MedianHouseIncome { get; set; }
        public int IssuesCount { get; set; }
    }
}

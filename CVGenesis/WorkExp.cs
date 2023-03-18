using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGenesis
{
    public class WorkExp
    {
        public WorkExp(string occupation, string employer, string country, string startYear, string endYear)
        {
            this._occupation = occupation;
            this._employer = employer;
            this._country = country;
            this._startYear = startYear;
            this._endYear = endYear;
        }

        public string _occupation { get; set; }
        public string _employer { get; set; }
        public string _country { get; set; }
        public string _startYear { get; set; }
        public string _endYear { get; set; }

        public string getWork()
        {
            return ($"{_occupation}\t{_employer}\t{_country}\t{_startYear}\t{_endYear}");
        }
    }
}

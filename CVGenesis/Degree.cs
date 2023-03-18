using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGenesis
{
    public class Degree
    {
        public Degree(string degree, string institute, string subjct, string endYear, double result, string publication, string author, string date)
        {
            this._degree = degree;
            this._institute = institute;
            this._subjct = subjct;
            this._endYear = endYear;
            this._result = result;
            this._publication= publication;
            this._author = author;
            this._date = date;
        }

        public string _degree { get; set; }
        public string _institute { get; set; }
        public string _subjct { get; set; }
        public string _endYear { get; set; }
        public double _result { get; set; }
        public string _publication { get; set; }
        public string _author { get; set; }
        public string _date { get; set; }

        public string getDegree()
        {
            return  ($"{_degree}\t{_institute}\t{_subjct}\t{_endYear}\t{_result}");
        }


    }
}

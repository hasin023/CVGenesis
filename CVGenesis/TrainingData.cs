using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGenesis
{
    public class TrainingData
    {
        public TrainingData(string name, string institute, string startYear, string endYear)
        {
            this._name = name;
            this._institute = institute;
            this._startYear = startYear;
            this._endYear = endYear;
        }

        public string _name { get; set; }
        public string _institute { get; set; }
        public string _startYear { get; set; }
        public string _endYear { get; set; }

        public string getTraining()
        {
            return ($"{_name}\t{_institute}\t{_startYear}\t{_endYear}");
        }
    }
}

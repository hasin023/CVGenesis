using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGenesis
{
    public class Awards
    {
        public Awards(string title, string @event, string intstitue, string year)
        {
            this._title = title;
            this._event = @event;
            this._intstitue = intstitue;
            this._Year = year;
        }

        public string _title { get; set; }
        public string _event { get; set; }
        public string _intstitue { get; set; }
        public string _Year { get; set; }

        public string getAward()
        {
            return ($"{_title}\t{_event}\t{_intstitue}\t{_Year}");
        }
    }
}

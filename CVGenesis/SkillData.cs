using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGenesis
{
    public class SkillData
    {
        public SkillData(string language, string digital, string other)
        {
            this._language = language;
            this._digital = digital;
            this._other = other;
        }

        public string _language { get; set; }
        public string _digital { get; set; }
        public string _other { get; set; }

        public string getSkill()
        {
            return ($"{_language}\t{_digital}\t{_other}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalApplication
{
    class UnitDataManagerXml
    {
        private List<Unit> _units;

        public UnitDataManagerXml(List<Unit> units)
        {
            _units = units;
        }

        public List<Unit> GetAllUnits()
        {
            return _units;
        }
    }
}

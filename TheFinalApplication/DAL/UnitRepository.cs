using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalApplication
{
    class UnitRepository : IDisposable
    {
        private List<Unit> _units;
        public void Dispose()
        {
            _units = null;
        }
    }
}

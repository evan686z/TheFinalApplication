using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFinalApplication.Models;

namespace TheFinalApplication.DAL
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

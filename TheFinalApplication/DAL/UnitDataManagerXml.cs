using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalApplication
{
    class UnitDataManagerXml : IDisposable
    {
        private List<Unit> _units;

        public UnitDataManagerXml(List<Unit> units)
        {
            _units = units;
        }
        // return index of unit
        public int GetUnitByIndex(int ID)
        {
            int unitIndex = 0;
            for (int index = 0; index < _units.Count(); index++)
            {
                if (_units[index].ID == ID)
                {
                    unitIndex = index;
                }
            }
            return unitIndex;
        }
        // add unit
        public async void InsertUnit(Unit unit)
        {
            _units.Add(unit);

            await UnitDataServiceXml.SaveObjectToXml(_units, "Data.xml");
        }
        // delete unit
        public async void DeleteSelectedUnit(int ID)
        {
            _units.RemoveAt(GetUnitByIndex(ID));

            await UnitDataServiceXml.SaveObjectToXml(_units, "Data.xml");
        }
        public void Dispose()
        {
            _units = null;
        }
    }
}

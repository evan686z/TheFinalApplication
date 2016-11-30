using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TheFinalApplication;

namespace TheFinalApplication
{
    public class InitializeData
    {
        public async static void WriteTestDataToFileXml()
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Unit() { UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });

            await UnitDataServiceXml.SaveObjectToXml(units, "Units.xml");
        }
    }
}

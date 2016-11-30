using System.Collections.Generic;

namespace TheFinalApplication
{
    public class IntializeData
    {
        public async static void WriteTestDataToFileXml()
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Unit() { ID = 1, UnitName = "Lightning", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { ID = 2, UnitName = "Cecil", UnitLVL = 100, UnitHP = 5875, UnitATK = 255, UnitMAG = 128, UnitMP = 184, UnitDEF = 437, UnitSPR = 174, UnitImage = "Assets/Unit-Cecil-6.png" });
            units.Add(new Unit() { ID = 3, UnitName = "Luneth", UnitLVL = 100, UnitHP = 4400, UnitATK = 552, UnitMAG = 182, UnitMP = 177, UnitDEF = 205, UnitSPR = 144, UnitImage = "Assets/Unit-Luneth-6.png" });
            units.Add(new Unit() { ID = 4, UnitName = "Exdeath", UnitLVL = 100, UnitHP = 3147, UnitATK = 150, UnitMAG = 451, UnitMP = 290, UnitDEF = 227, UnitSPR = 171, UnitImage = "Assets/Unit-Exdeath-6.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Tilith", UnitLVL = 80, UnitHP = 2174, UnitATK = 95, UnitMAG = 195, UnitMP = 292, UnitDEF = 145, UnitSPR = 263, UnitImage = "Assets/Unit-Tilith-5.png" });

            await UnitDataServiceXml.SaveObjectToXml(units, "Units.xml");
        }
    }
}

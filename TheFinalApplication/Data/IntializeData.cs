using System.Collections.Generic;

namespace TheFinalApplication
{
    public class IntializeData
    {
        public async static void WriteTestDataToFileXml()
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Unit() { ID = 1, UnitName = "Lightning", UnitJob = "l'Cie", UnitLVL = 100, UnitHP = 4379, UnitATK = 476, UnitMAG = 199, UnitMP = 215, UnitDEF = 181, UnitSPR = 177, UnitImage = "Assets/Unit-Lightning-6.png" });
            units.Add(new Unit() { ID = 2, UnitName = "Cecil", UnitJob = "Paladin", UnitLVL = 100, UnitHP = 5875, UnitATK = 255, UnitMAG = 128, UnitMP = 184, UnitDEF = 437, UnitSPR = 174, UnitImage = "Assets/Unit-Cecil-6.png" });
            units.Add(new Unit() { ID = 3, UnitName = "Luneth", UnitJob = "Warrior", UnitLVL = 100, UnitHP = 4400, UnitATK = 552, UnitMAG = 182, UnitMP = 177, UnitDEF = 205, UnitSPR = 144, UnitImage = "Assets/Unit-Luneth-6.png" });
            units.Add(new Unit() { ID = 4, UnitName = "Exdeath", UnitJob = "Dark Mage", UnitLVL = 100, UnitHP = 3147, UnitATK = 150, UnitMAG = 451, UnitMP = 290, UnitDEF = 227, UnitSPR = 171, UnitImage = "Assets/Unit-Exdeath-6.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Tilith", UnitJob = "Goddess", UnitLVL = 80, UnitHP = 2174, UnitATK = 95, UnitMAG = 195, UnitMP = 292, UnitDEF = 145, UnitSPR = 263, UnitImage = "Assets/Unit-Tilith-5.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Arc", UnitJob = "Black Wizard", UnitLVL = 80, UnitHP = 2097, UnitATK = 88, UnitMAG = 235, UnitMP = 193, UnitDEF = 140, UnitSPR = 119, UnitImage = "Assets/Unit-Arc-5.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Cloud of Darkness", UnitJob = "Ravager", UnitLVL = 100, UnitHP = 4015, UnitATK = 394, UnitMAG = 153, UnitMP = 171, UnitDEF = 165, UnitSPR = 106, UnitImage = "Assets/Unit-Cloud_of_Darkness-6.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Delita", UnitJob = "Squire", UnitLVL = 100, UnitHP = 2174, UnitATK = 95, UnitMAG = 195, UnitMP = 292, UnitDEF = 145, UnitSPR = 263, UnitImage = "Assets/Unit-Delita-6.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Gilgamesh", UnitJob = "Guard Captain", UnitLVL = 100, UnitHP = 4766, UnitATK = 633, UnitMAG = 156, UnitMP = 196, UnitDEF = 262, UnitSPR = 149, UnitImage = "Assets/Unit-Gilgamesh-6.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Kefka", UnitJob = "Archmage", UnitLVL = 80, UnitHP = 2115, UnitATK = 83, UnitMAG = 280, UnitMP = 150, UnitDEF = 123, UnitSPR = 116, UnitImage = "Assets/Unit-Kefka-5.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Tellah", UnitJob = "Sage", UnitLVL = 80, UnitHP = 2117, UnitATK = 89, UnitMAG = 227, UnitMP = 129, UnitDEF = 121, UnitSPR = 120, UnitImage = "Assets/Unit-Tellah-5.png" });
            units.Add(new Unit() { ID = 5, UnitName = "Refia", UnitJob = "White Wizard", UnitLVL = 100, UnitHP = 3622, UnitATK = 153, UnitMAG = 153, UnitMP = 286, UnitDEF = 191, UnitSPR = 456, UnitImage = "Assets/Unit-Refia-6.png" });

            await UnitDataServiceXml.SaveObjectToXml(units, "Units.xml");
        }
    }
}

using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Buffs
{
    public static class CritsBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Quality over Quantity I",
                    Description = "All towers gain crit chance equal to their level but lose 1 base damage",
                    SpriteName = "Crits",
                    UnlockName = "GlobalCritLevel1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "GlobalCritLevel2" },
                    Unlocked = true,
                    Category = Category.Buff,
                    Subcategory = Subcategory.CritsBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Quality over Quantity II",
                    Description = "All towers gain crit chance equal to their level but lose 1 base damage",
                    SpriteName = "Crits",
                    UnlockName = "GlobalCritLevel2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "GlobalCritLevel3" },
                    Unlocked = true,
                    Category = Category.Buff,
                    Subcategory = Subcategory.CritsBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Quality over Quantity III",
                    Description = "All towers gain crit chance equal to their level but lose 1 base damage",
                    SpriteName = "Crits",
                    UnlockName = "GlobalCritLevel3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Buff,
                    Subcategory = Subcategory.CritsBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

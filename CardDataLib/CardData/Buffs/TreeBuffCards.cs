using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Buffs
{
    public static class TreeBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Golden Forest I",
                    Description = "Trees now have a chance to drop upgrade cards when chopped",
                    SpriteName = "Pluses",
                    UnlockName = "TreeCard1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "TreeCard2" },
                    Unlocked = true,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TreeBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Golden Forest II",
                    Description = "Double the chance that a tree drops cards",
                    SpriteName = "Pluses",
                    UnlockName = "TreeCard2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TreeBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

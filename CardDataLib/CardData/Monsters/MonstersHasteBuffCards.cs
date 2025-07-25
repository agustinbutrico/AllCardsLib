using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Monsters
{
    public static class MonstersHasteBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Quickness I",
                    Description = "Increase monsters' maximum haste by 10%",
                    SpriteName = "Haste",
                    UnlockName = "MonsterQuickness1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterQuickness2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterHasteBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Quickness II",
                    Description = "Increase monsters' maximum haste by 10%",
                    SpriteName = "Haste",
                    UnlockName = "MonsterQuickness2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterQuickness3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterHasteBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Quickness III",
                    Description = "Increase monsters' maximum haste by 10%",
                    SpriteName = "Haste",
                    UnlockName = "MonsterQuickness3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterQuickness4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterHasteBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Quickness IV",
                    Description = "Increase monsters' maximum haste by 10%",
                    SpriteName = "Haste",
                    UnlockName = "MonsterQuickness4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterHasteBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

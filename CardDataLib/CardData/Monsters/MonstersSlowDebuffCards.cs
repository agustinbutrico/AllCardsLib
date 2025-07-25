using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Monsters
{
    public static class MonstersSlowDebuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Perserverance I",
                    Description = "Decrease monsters' maximum slow by 5%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterPerserverance2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Perserverance II",
                    Description = "Decrease monsters' maximum slow by 5%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterPerserverance3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Perserverance III",
                    Description = "Decrease monsters' maximum slow by 10%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterPerserverance4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Perserverance IV",
                    Description = "Decrease monsters' maximum slow by 10%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterPerserverance5" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Perserverance V",
                    Description = "Decrease monsters' maximum slow by 15%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterPerserverance6" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Perserverance VI",
                    Description = "Decrease monsters' maximum slow by 15%",
                    SpriteName = "Frost",
                    UnlockName = "MonsterPerserverance6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterSlowDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

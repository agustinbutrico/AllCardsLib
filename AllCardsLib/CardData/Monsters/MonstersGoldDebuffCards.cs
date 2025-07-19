using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Monsters
{
    public static class MonstersGoldDebuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Frugal I",
                    Description = "Monsters drop 1 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "Frugal2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Frugal II",
                    Description = "Monsters drop 1 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "Frugal3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Frugal III",
                    Description = "Monsters drop 2 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "Frugal4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Frugal IV",
                    Description = "Monsters drop 2 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "Frugal5" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Frugal V",
                    Description = "Monsters drop 3 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "Frugal6" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Frugal VI",
                    Description = "Monsters drop 3 less gold",
                    SpriteName = "Bank",
                    UnlockName = "Frugal6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterGoldDebuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

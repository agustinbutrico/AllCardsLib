using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Buildings
{
    public static class ManaBankCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Mana Bank",
                    Description = "Generates mana through the magic of the magic market",
                    SpriteName = "ManaBank",
                    UnlockName = "ManaBank",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Savings1" },
                    Unlocked = false,
                    Category = Category.Building,
                    Subcategory = Subcategory.ManaBank,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Savings Account I",
                    Description = "All mana banks store an extra 15 maximum mana",
                    SpriteName = "ManaBank",
                    UnlockName = "Savings1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Savings2" },
                    Unlocked = false,
                    Category = Category.Building,
                    Subcategory = Subcategory.ManaBank,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Savings Account II",
                    Description = "All mana banks store an extra 15 maximum mana",
                    SpriteName = "ManaBank",
                    UnlockName = "Savings2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Building,
                    Subcategory = Subcategory.ManaBank,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                }
            });
        }
    }
}

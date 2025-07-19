using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buildings
{
    public static class MineCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Mine",
                    Description = "Repair and increases tower max health by mining from iron veins",
                    SpriteName = "Mine",
                    UnlockName = "Mine",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GoldRush" },
                    Unlocked = false,
                    Category = Category.Building,
                    Subcategory = Subcategory.Mine,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Gold Rush!",
                    Description = "Enemies drop +3g when they die. However they also gain +0.25 speed",
                    SpriteName = "Mine",
                    UnlockName = "GoldRush",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Building,
                    Subcategory = Subcategory.Mine,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                }
            });
        }
    }
}

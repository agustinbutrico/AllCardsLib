using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buildings
{
    public static class HauntedHouseCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Haunted House",
                    Description = "Communicate with and tax the dead from nearby graves",
                    SpriteName = "HauntedHouse",
                    UnlockName = "HauntedHouse",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Seance1" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "HauntedHouse",
                },
                new CardDisplayData
                {
                    Title = "Seance I",
                    Description = "Raise the death tax rate by 15%",
                    SpriteName = "HauntedHouse",
                    UnlockName = "Seance1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Seance2" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "HauntedHouse",
                },
                new CardDisplayData
                {
                    Title = "Seance II",
                    Description = "Raise the death tax rate by 10%",
                    SpriteName = "HauntedHouse",
                    UnlockName = "Seance2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Seance3" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "HauntedHouse",
                },
                new CardDisplayData
                {
                    Title = "Seance III",
                    Description = "Raise the death tax rate by 5%",
                    SpriteName = "HauntedHouse",
                    UnlockName = "Seance3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "HauntedHouse",
                },
            });
        }
    }
}

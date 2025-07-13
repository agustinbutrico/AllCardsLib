using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buildings
{
    public static class UniversityCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "University",
                    Description = "Place next to occult shrines to discover lost knowledge",
                    SpriteName = "Book",
                    UnlockName = "University",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Scholarships1" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Scholarships I",
                    Description = "All universities gain a +3% bonus to all research",
                    SpriteName = "Book",
                    UnlockName = "Scholarships1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Scholarships2", "Reasearch1" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Scholarships II",
                    Description = "All universities gain a +2% bonus to all research",
                    SpriteName = "Book",
                    UnlockName = "Scholarships2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Scholarships3", "Reasearch2" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Scholarships III",
                    Description = "All universities gain a +1% bonus to all research",
                    SpriteName = "Book",
                    UnlockName = "Scholarships3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Reasearch3" },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Research Breakthrough!",
                    Description = "All towers gain +5% crit chance",
                    SpriteName = "Book",
                    UnlockName = "Reasearch1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Research Breakthrough!",
                    Description = "All towers gain +5% crit chance",
                    SpriteName = "Book",
                    UnlockName = "Reasearch2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                },
                new CardDisplayData
                {
                    Title = "Research Breakthrough!",
                    Description = "All towers gain +5% crit chance",
                    SpriteName = "Book",
                    UnlockName = "Reasearch3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Building,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = "University",
                }
            });
        }
    }
}

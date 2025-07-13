using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buffs
{
    public static class CardsBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Card Draw I",
                    Description = "Draw an additional card when you draw upgrade cards",
                    SpriteName = "Pluses",
                    UnlockName = "CardDraw1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "CardDraw2" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Card Draw II",
                    Description = "Draw an additional card when you draw upgrade cards",
                    SpriteName = "Pluses",
                    UnlockName = "CardDraw2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "CardDraw3" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Card Draw III",
                    Description = "Draw an additional card when you draw upgrade cards",
                    SpriteName = "Pluses",
                    UnlockName = "CardDraw3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Treasure" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Draw Frequency I",
                    Description = "Draw upgrade cards every 2 rounds",
                    SpriteName = "Pluses",
                    UnlockName = "CardFreq1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "CardFreq2" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Draw Frequency II",
                    Description = "Draw upgrade cards every round",
                    SpriteName = "Pluses",
                    UnlockName = "CardFreq2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasure!",
                    Description = "Draw an additional card from treasure chests",
                    SpriteName = "Pluses",
                    UnlockName = "TreasureDraw1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                }
            });
        }
    }
}

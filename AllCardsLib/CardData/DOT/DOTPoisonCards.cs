using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.DOT
{
    public static class DOTPoisonCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData {
                    Title = "Slow but Sure I",
                    Description = "Increase maximum poison/sec by +26 to 50",
                    SpriteName = "Poison",
                    UnlockName = "DOTPoison1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "DOTPoison2", "PoisonExtraDamage1", "PoisonSlow" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Slow but Sure II",
                    Description = "Increase maximum poison/sec by +30 to 80",
                    SpriteName = "Poison",
                    UnlockName = "DOTPoison2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "DOTAll3" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Vile Consumption I",
                    Description = "Poisoned enemies take an extra +1 shield damage from all attacks",
                    SpriteName = "Poison",
                    UnlockName = "PoisonExtraDamage1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "PoisonExtraDamage2", "PoisonPop1" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Vile Consumption II",
                    Description = "Poisoned enemies take an extra +1 shield damage from all attacks",
                    SpriteName = "Poison",
                    UnlockName = "PoisonExtraDamage2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "PoisonExtraDamage3" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Vile Consumption III",
                    Description = "Poisoned enemies take an extra +1 shield damage from all attacks",
                    SpriteName = "Poison",
                    UnlockName = "PoisonExtraDamage3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Creeping Cough",
                    Description = "Poisoning enemies also slows them by 5% of poison gained",
                    SpriteName = "Poison",
                    UnlockName = "PoisonSlow",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Expunge I",
                    Description = "Crits deal 10% of the target's current poison as extra poison damage",
                    SpriteName = "Poison",
                    UnlockName = "PoisonPop1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "PoisonPop2" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Expunge II",
                    Description = "Crits deal an additional 10% of the target's current poison as extra poison damage",
                    SpriteName = "Poison",
                    UnlockName = "PoisonPop2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Make them Suffer",
                    Description = "Increase max bleed, burn and poison/sec by +40",
                    SpriteName = "Flame",
                    UnlockName = "DOTAll3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                }
            });
        }
    }
}

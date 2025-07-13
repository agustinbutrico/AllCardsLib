using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.DOT
{
    public static class DOTBleedCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                 new CardDisplayData {
                    Title = "Bleed them Dry I",
                    Description = "Increase maximum bleed/sec by +26 to 50",
                    SpriteName = "Bleed",
                    UnlockName = "DOTBleed1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "DOTBleed2", "BleedExtraDamage1", "BleedCrits" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Bleed them Dry II",
                    Description = "Increase maximum bleed/sec by +30 to 80",
                    SpriteName = "Bleed",
                    UnlockName = "DOTBleed2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "DOTAll1" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Trail of Blood I",
                    Description = "Bleeding enemies take an extra +1 health damage from all attacks",
                    SpriteName = "Bleed",
                    UnlockName = "BleedExtraDamage1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "BleedExtraDamage2", "BleedPop1" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Trail of Blood II",
                    Description = "Bleeding enemies take an extra +1 health damage from all attacks",
                    SpriteName = "Bleed",
                    UnlockName = "BleedExtraDamage2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "BleedExtraDamage3" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Trail of Blood III",
                    Description = "Bleeding enemies take an extra +1 health damage from all attacks",
                    SpriteName = "Bleed",
                    UnlockName = "BleedExtraDamage3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Eviscerate",
                    Description = "Attacks against bleeding enemies have +5% crit chance",
                    SpriteName = "Bleed",
                    UnlockName = "BleedCrits",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Exsanguinate I",
                    Description = "Crits deal 10% of the target's current bleed as extra bleed damage",
                    SpriteName = "Bleed",
                    UnlockName = "BleedPop1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "BleedPop2" },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Exsanguinate II",
                    Description = "Crits deal an additional 10% of the target's current bleed as extra bleed damage",
                    SpriteName = "Bleed",
                    UnlockName = "BleedPop2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.DOT,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData {
                    Title = "Make them Suffer",
                    Description = "Increase max bleed, burn and poison/sec by +40",
                    SpriteName = "Flame",
                    UnlockName = "DOTAll1",
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

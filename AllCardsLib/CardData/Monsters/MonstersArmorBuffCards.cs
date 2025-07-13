using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Monsters
{
    public static class MonstersArmorBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Monster Armor I",
                    Description = "Monsters gain an additional 5% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor2" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor II",
                    Description = "Monsters gain an additional 5% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor3" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor III",
                    Description = "Monsters gain an additional 5% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor4" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor IV",
                    Description = "Monsters gain an additional 10% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor5" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor V",
                    Description = "Monsters gain an additional 10% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor6" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor VI",
                    Description = "Monsters gain an additional 10% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor7" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor VII",
                    Description = "Monsters gain an additional 15% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor7",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor8" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor VIII",
                    Description = "Monsters gain an additional 15% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor8",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor9" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor IX",
                    Description = "Monsters gain an additional 15% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor9",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor10" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor X",
                    Description = "Monsters gain an additional 20% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor10",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor11" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XI",
                    Description = "Monsters gain an additional 20% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor11",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor12" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XII",
                    Description = "Monsters gain an additional 20% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor12",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor13" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XIII",
                    Description = "Monsters gain an additional 25% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor13",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor14" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XIV",
                    Description = "Monsters gain an additional 25% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor14",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor15" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XV",
                    Description = "Monsters gain an additional 50% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor15",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor16" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XVI",
                    Description = "Monsters gain an additional 50% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor16",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor17" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XVII",
                    Description = "Monsters gain an additional 50% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor17",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor18" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XVIII",
                    Description = "Monsters gain an additional 50% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor18",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor19" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XIX",
                    Description = "Monsters gain an additional 100% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor19",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterArmor20" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Armor XX",
                    Description = "Monsters gain an additional 100% armor",
                    SpriteName = "Armor",
                    UnlockName = "MonsterArmor20",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                }
            });
        }
    }
}

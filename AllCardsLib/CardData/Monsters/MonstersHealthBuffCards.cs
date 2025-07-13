using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Monsters
{
    public static class MonstersHealthBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Monster Health I",
                    Description = "Monsters gain an additional 5% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth2" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health II",
                    Description = "Monsters gain an additional 5% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth3" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health III",
                    Description = "Monsters gain an additional 5% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth4" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health IV",
                    Description = "Monsters gain an additional 10% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth5" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health V",
                    Description = "Monsters gain an additional 10% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth6" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health VI",
                    Description = "Monsters gain an additional 10% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth7" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health VII",
                    Description = "Monsters gain an additional 15% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth7",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth8" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health VIII",
                    Description = "Monsters gain an additional 15% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth8",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth9" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health IX",
                    Description = "Monsters gain an additional 15% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth9",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth10" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health X",
                    Description = "Monsters gain an additional 20% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth10",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth11" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XI",
                    Description = "Monsters gain an additional 20% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth11",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth12" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XII",
                    Description = "Monsters gain an additional 20% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth12",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth13" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XIII",
                    Description = "Monsters gain an additional 25% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth13",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth14" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XIV",
                    Description = "Monsters gain an additional 25% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth14",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth15" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XV",
                    Description = "Monsters gain an additional 50% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth15",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth16" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XVI",
                    Description = "Monsters gain an additional 50% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth16",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth17" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XVII",
                    Description = "Monsters gain an additional 50% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth17",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth18" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XVIII",
                    Description = "Monsters gain an additional 50% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth18",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth19" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XIX",
                    Description = "Monsters gain an additional 100% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth19",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterHealth20" },
                    Unlocked = true,
                    Category = CardCategory.Monster,
                    AcquisitionType = CardAcquisitionType.AlwaysInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Monster Health XX",
                    Description = "Monsters gain an additional 100% health",
                    SpriteName = "Heart",
                    UnlockName = "MonsterHealth20",
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

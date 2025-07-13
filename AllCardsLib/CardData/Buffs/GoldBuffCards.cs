using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buffs
{
    public static class GoldBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Banditry I",
                    Description = "Enemies drop +2 gold on death, but they also deal +1 damage to the tower",
                    SpriteName = "Bank",
                    UnlockName = "MonsterBonusGold1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MonsterBonusGold2" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Banditry II",
                    Description = "Enemies drop +2 gold on death, but they also deal +1 damage to the tower",
                    SpriteName = "Bank",
                    UnlockName = "MonsterBonusGold2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MonsterBonusGold3" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Banditry III",
                    Description = "Enemies drop +2 gold on death, but they also deal +1 damage to the tower",
                    SpriteName = "Bank",
                    UnlockName = "MonsterBonusGold3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreUnlocksInRun,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Gold Drop I",
                    Description = "All enemies drop an additional 1 gold when they die",
                    SpriteName = "Bank",
                    UnlockName = "GoldDrop1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GoldDrop2" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Gold Drop II",
                    Description = "All enemies drop an additional 1 gold when they die",
                    SpriteName = "Bank",
                    UnlockName = "GoldDrop2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GoldDrop3" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Gold Drop III",
                    Description = "All enemies drop an additional 1 gold when they die",
                    SpriteName = "Bank",
                    UnlockName = "GoldDrop3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GoldDrop4" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Gold Drop IV",
                    Description = "All enemies drop an additional 1 gold when they die",
                    SpriteName = "Bank",
                    UnlockName = "GoldDrop4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GoldDrop5" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Gold Drop V",
                    Description = "All enemies drop an additional 1 gold when they die",
                    SpriteName = "Bank",
                    UnlockName = "GoldDrop5",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury I",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold2" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury II",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold3" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury III",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold4" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury IV",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold5" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury V",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold5",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold6" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury VI",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold6",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold7" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury VII",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold7",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold8" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury VIII",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold8",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold9" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury IX",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold9",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "StartGold10" },
                    Unlocked = false,
                    Category = CardCategory.Buff,
                    AcquisitionType = CardAcquisitionType.StoreAppliesPermanent,
                    AssociatedTowerOrBuilding = null,
                },
                new CardDisplayData
                {
                    Title = "Treasury X",
                    Description = "Begin the game with an extra 100 gold",
                    SpriteName = "Bank",
                    UnlockName = "StartGold10",
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

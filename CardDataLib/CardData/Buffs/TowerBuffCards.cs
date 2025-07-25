using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Buffs
{
    public static class TowerBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Fortification I",
                    Description = "Increase main tower's max health by +3",
                    SpriteName = "TowerIcon",
                    UnlockName = "Fortification1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Fortification2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Fortification II",
                    Description = "Increase main tower's max health by +3",
                    SpriteName = "TowerIcon",
                    UnlockName = "Fortification2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Fortification3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Fortification III",
                    Description = "Increase main tower's max health by +3",
                    SpriteName = "TowerIcon",
                    UnlockName = "Fortification3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Fortification4" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Fortification IV",
                    Description = "Increase main tower's max health by +3",
                    SpriteName = "TowerIcon",
                    UnlockName = "Fortification4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Repair I",
                    Description = "Every level there is between a 0% to 33% chance your tower repairs 1 damage",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerRepair1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerRepair2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Repair II",
                    Description = "Increase you tower's repair chance to between 0% to 66% depending on tower health",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerRepair2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerRepair3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Repair III",
                    Description = "Increase you tower's repair chance to between 0% to 100% depending on tower health",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerRepair3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                    Subcategory = Subcategory.TowerBuff,
                    Category = Category.Buff,
                },
                new CardDisplayData
                {
                    Title = "Fortification I",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification II",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification III",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth4" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification IV",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth5" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification V",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth5",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth6" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification VI",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth6",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth7" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification VII",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth7",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth8" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification VIII",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth8",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth9" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification IX",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth9",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "TowerHealth10" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Fortification X",
                    Description = "Increase your tower's hit points by +1",
                    SpriteName = "TowerIcon",
                    UnlockName = "TowerHealth10",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.TowerBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                }
            });
        }
    }
}

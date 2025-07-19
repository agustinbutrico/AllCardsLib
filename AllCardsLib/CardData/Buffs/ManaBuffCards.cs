using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buffs
{
    public static class ManaBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Sorcery I",
                    Description = "Regenerate 1% of your max mana per second",
                    SpriteName = "ManaCrystal",
                    UnlockName = "Sourcery1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Sourcery2", "LifeSteal1" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Sorcery II",
                    Description = "Regenerate another 2% of your max mana per second",
                    SpriteName = "ManaCrystal",
                    UnlockName = "Sourcery2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "Sourcery3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Sorcery III",
                    Description = "Regenerate another 3% of your max mana per second",
                    SpriteName = "ManaCrystal",
                    UnlockName = "Sourcery3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Life Steal I",
                    Description = "Every enemy killed regenerates 1% max mana",
                    SpriteName = "ManaCrystal",
                    UnlockName = "LifeSteal1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "LifeSteal2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Life Steal II",
                    Description = "Every enemy killed regenerates an additional 1% max mana",
                    SpriteName = "ManaCrystal",
                    UnlockName = "LifeSteal2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "LifeSteal3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Life Steal III",
                    Description = "Every enemy killed regenerates an additional 1% max mana",
                    SpriteName = "ManaCrystal",
                    UnlockName = "LifeSteal3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Sourcery I",
                    Description = "Generate 1 mana/sec at the tower",
                    SpriteName = "ManaCrystal",
                    UnlockName = "ManaGen1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ManaGen2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Sourcery II",
                    Description = "Generate an additional 1 mana/sec at the tower",
                    SpriteName = "ManaCrystal",
                    UnlockName = "ManaGen2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ManaGen3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Sourcery III",
                    Description = "Generate an additional 1 mana/sec at the tower",
                    SpriteName = "ManaCrystal",
                    UnlockName = "ManaGen3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Mana Capacity I",
                    Description = "Increase your maximum mana capacity by +20",
                    SpriteName = "ManaCrystal",
                    UnlockName = "MaxMana1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MaxMana2" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Mana Capacity II",
                    Description = "Increase your maximum mana capacity by +20",
                    SpriteName = "ManaCrystal",
                    UnlockName = "MaxMana2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MaxMana3" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Mana Capacity III",
                    Description = "Increase your maximum mana capacity by +20",
                    SpriteName = "ManaCrystal",
                    UnlockName = "MaxMana3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MaxMana4" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Mana Capacity IV",
                    Description = "Increase your maximum mana capacity by +20",
                    SpriteName = "ManaCrystal",
                    UnlockName = "MaxMana4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "MaxMana5" },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData
                {
                    Title = "Mana Capacity V",
                    Description = "Increase your maximum mana capacity by +20",
                    SpriteName = "ManaCrystal",
                    UnlockName = "MaxMana5",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Buff,
                    Subcategory = Subcategory.ManaBuff,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                }
            });
        }
    }
}

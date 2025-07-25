﻿using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Towers
{
    public static class SawbladeCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Shredder",
                    Description = "Launches saw blades to rip and tear until it is done",
                    SpriteName = "Sawblade",
                    UnlockName = "Shredder",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderHealth1", "ShredderArmor1", "ShredderShield1", "ShredderBleed1" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Sharpened Blades I",
                    Description = "All shredders gain +1 damage to health",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderHealth1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "ShredderHealth2" },
                    Unlocked = true,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Sharpened Blades II",
                    Description = "All shredders gain +2 damage to health",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderHealth2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "ShredderHealth3" },
                    Unlocked = true,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Sharpened Blades III",
                    Description = "All shredders gain +3 damage to health",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderHealth3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "ShredderDamage1" },
                    Unlocked = true,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Hardened Blades I",
                    Description = "All shredders gain +1 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderArmor1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderArmor2" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Hardened Blades II",
                    Description = "All shredders gain +2 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderArmor2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderArmor3" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Hardened Blades III",
                    Description = "All shredders gain +3 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderArmor3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderDamage2" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Magnetic Blades I",
                    Description = "All shredders gain +1 damage to shields",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderShield1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderShield2" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Magnetic Blades II",
                    Description = "All shredders gain +2 damage to shields",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderShield2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderShield3" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Magnetic Blades III",
                    Description = "All shredders gain +3 damage to shields",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderShield3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderDamage3" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Thrashing I",
                    Description = "All shredders gain +50% bleed",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderBleed1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderBleed2" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Thrashing II",
                    Description = "All shredders gain +50% bleed",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderBleed2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderBleed3" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Thrashing III",
                    Description = "All shredders gain +50% bleed",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderBleed3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "ShredderBleed4" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Thrashing IV",
                    Description = "All shredders gain +50% bleed",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderBleed4",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Everything Bleeds",
                    Description = "Increase maximum bleed/sec by +100",
                    SpriteName = "Sawblade",
                    UnlockName = "BleedIncrease1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Everything Bleeds",
                    Description = "Increase maximum bleed/sec by +100",
                    SpriteName = "Sawblade",
                    UnlockName = "BleedIncrease2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Everything Bleeds",
                    Description = "Increase maximum bleed/sec by +100",
                    SpriteName = "Sawblade",
                    UnlockName = "BleedIncrease3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Shredding",
                    Description = "All shredders gain +15% crit chance",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderDamage1",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GlobalHealth10", "BleedIncrease1" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Shredding",
                    Description = "All shredders gain +15% crit chance",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderDamage2",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GlobalArmor10", "BleedIncrease2" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Shredding",
                    Description = "All shredders gain +15% crit chance",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderDamage3",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { "GlobalShield10", "BleedIncrease3" },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Studies",
                    Description = "All towers gain +1 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "GlobalHealth10",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Studies",
                    Description = "All towers gain +1 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "GlobalArmor10",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Studies",
                    Description = "All towers gain +1 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "GlobalShield10",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> { },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreUnlocksInRun,
                },
                new CardDisplayData {
                    Title = "Better Sawblades",
                    Description = "Sawblades permanently gain +1 damage to health",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderPHealth",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData {
                    Title = "Better Sawblades",
                    Description = "Sawblades permanently gain +1 damage to armor",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderPArmor",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                },
                new CardDisplayData {
                    Title = "Better Sawblades",
                    Description = "Sawblades permanently gain +1 damage to shield",
                    SpriteName = "Sawblade",
                    UnlockName = "ShredderPShield",
                    UnlockedByDefault = false,
                    Unlocks = new List<string> {  },
                    Unlocked = false,
                    Category = Category.Tower,
                    Subcategory = Subcategory.Shredder,
                    AcquisitionType = AcquisitionType.StoreAppliesPermanent,
                }
            });
        }
    }
}

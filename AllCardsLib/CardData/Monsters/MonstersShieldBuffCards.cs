using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Monsters
{
    public static class MonstersShieldBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Monster Shields I",
                    Description = "Monsters gain an additional 5% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields II",
                    Description = "Monsters gain an additional 5% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields III",
                    Description = "Monsters gain an additional 5% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields IV",
                    Description = "Monsters gain an additional 10% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields5" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields V",
                    Description = "Monsters gain an additional 10% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields6" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields VI",
                    Description = "Monsters gain an additional 10% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields7" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields VII",
                    Description = "Monsters gain an additional 15% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields7",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields8" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields VIII",
                    Description = "Monsters gain an additional 15% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields8",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields9" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields IX",
                    Description = "Monsters gain an additional 15% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields9",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields10" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields X",
                    Description = "Monsters gain an additional 20% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields10",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields11" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XI",
                    Description = "Monsters gain an additional 20% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields11",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields12" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XII",
                    Description = "Monsters gain an additional 20% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields12",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields13" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XIII",
                    Description = "Monsters gain an additional 25% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields13",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields14" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XIV",
                    Description = "Monsters gain an additional 25% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields14",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields15" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XV",
                    Description = "Monsters gain an additional 50% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields15",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields16" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XVI",
                    Description = "Monsters gain an additional 50% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields16",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields17" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XVII",
                    Description = "Monsters gain an additional 50% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields17",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields18" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XVIII",
                    Description = "Monsters gain an additional 50% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields18",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields19" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XIX",
                    Description = "Monsters gain an additional 100% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields19",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterShields20" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Monster Shields XX",
                    Description = "Monsters gain an additional 100% shields",
                    SpriteName = "Shield",
                    UnlockName = "MonsterShields20",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterShieldBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

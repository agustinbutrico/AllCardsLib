using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Monsters
{
    public static class MonstersTowerDamageBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Protection I",
                    Description = "Fortified monsters reduce incoming base damage by a further 1",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection II",
                    Description = "Fortified monsters reduce incoming base damage by a further 1",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection III",
                    Description = "Fortified monsters reduce incoming base damage by a further 1",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection IV",
                    Description = "Fortified monsters reduce incoming base damage by a further 2",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection5" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection V",
                    Description = "Fortified monsters reduce incoming base damage by a further 2",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection6" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection VI",
                    Description = "Fortified monsters reduce incoming base damage by a further 2",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection7" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection VII",
                    Description = "Fortified monsters reduce incoming base damage by a further 3",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection7",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterProtection8" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Protection VIII",
                    Description = "Fortified monsters reduce incoming base damage by a further 3",
                    SpriteName = "Fortified",
                    UnlockName = "MonsterProtection8",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterTowerDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

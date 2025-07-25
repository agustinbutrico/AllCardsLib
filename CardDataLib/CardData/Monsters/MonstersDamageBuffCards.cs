﻿using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Monsters
{
    public static class MonstersDamageBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Destruction I",
                    Description = "Monsters deal an additional 1 damage",
                    SpriteName = "Plus1",
                    UnlockName = "MonsterDestruction1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterDestruction2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Destruction II",
                    Description = "Monsters deal an additional 1 damage",
                    SpriteName = "Plus1",
                    UnlockName = "MonsterDestruction2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterDestruction3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Destruction III",
                    Description = "Monsters deal an additional 1 damage",
                    SpriteName = "Plus1",
                    UnlockName = "MonsterDestruction3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterDamageBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

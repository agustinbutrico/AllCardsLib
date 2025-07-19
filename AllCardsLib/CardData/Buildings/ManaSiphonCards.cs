using System.Collections.Generic;
using CardsShared;

namespace AllCardsLib.CardData.Buildings
{
    public static class ManaSiphonCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Mana Siphon",
                    Description = "Siphon mana from crystals",
                    SpriteName = "ManaCrystal",
                    UnlockName = "ManaSiphon",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Building,
                    Subcategory = Subcategory.ManaSiphon,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}

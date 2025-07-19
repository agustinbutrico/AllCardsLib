using AllCardsLib.Corrections;
using CardsShared;
using System.Collections.Generic;
using System.Linq;
using TexturesLib.Shared;

namespace AllCardsLib
{
    public static partial class AllCardsLibAPI
    {
        public static void LoadAllCards()
        {
            if (Plugin.CardDisplayDataCollection.AllCards.Count == 0)
                CardData.CardsRegisterManager.RegisterAllCards();

            foreach (var card in Plugin.CardDisplayDataCollection.AllCards)
            {
                var sprite = SpriteHelper.FindSpriteByName(card.SpriteName);
                if (sprite != null)
                    card.Sprite = sprite;
                else
                    Plugin.Log.LogWarning($"Sprite '{card.SpriteName}' not found for card '{card.Title}' via SpriteHelper.");
            }

            Plugin.Log.LogDebug($"Loaded {Plugin.CardDisplayDataCollection.AllCards.Count} cards into the library using preloaded TexturesLib/Cards sprites.");

        }

        public static List<CardDisplayData> GetAllCards() => Plugin.CardDisplayDataCollection.AllCards.ToList();

        public static List<CardDisplayData> FilterCards(
            Category? category = null,
            AcquisitionType? acquisitionType = null,
            Subcategory? subcategory = null,
            bool? unlocked = null)
        {
            return Plugin.CardDisplayDataCollection.AllCards
                .Where(card =>
                    (category == null || card.Category == category.Value) &&
                    (acquisitionType == null || (card.AcquisitionType & acquisitionType.Value) != 0) &&
                    (subcategory == null || card.Subcategory == subcategory) &&
                    (unlocked == null || card.Unlocked == unlocked.Value)
                ).ToList();
        }

        public static CardDisplayData GetCard(string cardTitle = null, string cardUnlockName = null)
        {
            if (string.IsNullOrEmpty(cardTitle) && string.IsNullOrEmpty(cardUnlockName))
            {
                Plugin.Log.LogWarning("GetCard called without cardTitle or cardUnlockName.");
                return null;
            }
            return Plugin.CardDisplayDataCollection.AllCards
                .FirstOrDefault(card =>
                    (cardTitle != null && card.Title == cardTitle) ||
                    (cardUnlockName != null && card.UnlockName == cardUnlockName));
        }

        public static void SyncCardUnlockedStatus()
        {
            SyncCardUnclocked.SyncCardUnlockedStatus();
        }
    }
}

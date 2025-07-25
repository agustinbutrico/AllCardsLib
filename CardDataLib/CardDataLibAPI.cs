using CardDataLib.Corrections;
using CardsShared;
using System.Collections.Generic;
using System.Linq;
using TexturesLib.Shared;

namespace CardDataLib
{
    public static partial class CardDataLibAPI
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

            Plugin.Log.LogInfo($"Loaded {Plugin.CardDisplayDataCollection.AllCards.Count} cards.");
        }

        public static List<CardDisplayData> GetAllCards() => Plugin.CardDisplayDataCollection.AllCards.ToList();

        public static List<CardDisplayData> FilterCards(
            Category? category = null,
            Subcategory? subcategory = null,
            AcquisitionType? acquisitionType = null,
            bool? unlocked = null)
        {
            return Plugin.CardDisplayDataCollection.AllCards
                .Where(card =>
                    (category == null || card.Category == category.Value) &&
                    (subcategory == null || card.Subcategory == subcategory) &&
                    (acquisitionType == null || (card.AcquisitionType & acquisitionType.Value) != 0) &&
                    (unlocked == null || card.Unlocked == unlocked.Value)
                ).ToList();
        }

        public static CardDisplayData GetCard(string cardUnlockName = null, string cardTitle = null)
        {
            if (string.IsNullOrEmpty(cardTitle) && string.IsNullOrEmpty(cardUnlockName))
            {
                Plugin.Log.LogWarning("GetCard called without cardTitle or cardUnlockName.");
                return null;
            }
            return Plugin.CardDisplayDataCollection.AllCards
                .FirstOrDefault(card =>
                    (cardUnlockName != null && card.UnlockName == cardUnlockName) ||
                    (cardTitle != null && card.Title == cardTitle));
        }

        public static void SyncCardUnlockedStatus()
        {
            SyncCardUnclocked.SyncCardUnlockedStatus();
        }
    }
}

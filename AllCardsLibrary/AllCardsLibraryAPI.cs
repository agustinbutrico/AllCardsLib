using System;
using System.Collections.Generic;
using System.Linq;
using CardsShared;
using UnityEngine;

namespace AllCardsLibrary
{
    /// <summary>
    /// Provides access to all hardcoded card data and helper methods for creating in-game card displays.
    /// </summary>
    public static partial class AllCardsLibraryAPI
    {
        private static readonly Dictionary<string, CardDisplayData> _allCards = new Dictionary<string, CardDisplayData>();
        private static readonly Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

        /// <summary>
        /// Loads all hardcoded card data into the API for querying.
        /// Must be called before accessing card data.
        /// </summary>
        public static void LoadAllCards()
        {
            if (_allCards.Count > 0)
            {
                return;
            }

            foreach (var card in GenerateAllCardData())
            {
                _allCards[card.Title] = card;

                if (!string.IsNullOrEmpty(card.SpriteBase64))
                {
                    try
                    {
                        byte[] data = Convert.FromBase64String(card.SpriteBase64);
                        Texture2D tex = new Texture2D(2, 2);
                        tex.LoadImage(data);
                        tex.name = card.SpriteName;
                        card.SpriteTexture = tex;
                        _spriteCache[card.SpriteName] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                    }
                    catch (Exception ex)
                    {
                        Plugin.Log.LogWarning($"Failed to decode sprite for '{card.Title}': {ex.Message}");
                    }
                }
            }

            Plugin.Log.LogInfo($"Loaded {_allCards.Count} cards into the library.");
        }

        /// <summary>
        /// Returns all loaded cards.
        /// </summary>
        public static List<CardDisplayData> GetAllCards() => _allCards.Values.ToList();

        /// <summary>
        /// Returns a card by its exact title or null if not found.
        /// </summary>
        public static CardDisplayData GetCardByTitle(string title) => _allCards.TryGetValue(title, out var card) ? card : null;

        /// <summary>
        /// Returns cards matching a custom predicate.
        /// </summary>
        public static List<CardDisplayData> FindCardsByPredicate(Func<CardDisplayData, bool> predicate) => _allCards.Values.Where(predicate).ToList();

        /// <summary>
        /// Returns cards whose Title or Description mention the towerName (case-insensitive).
        /// </summary>
        public static List<CardDisplayData> ObtainCardsByTower(string towerName)
        {
            return _allCards.Values.Where(card =>
                (!string.IsNullOrEmpty(card.Title) && card.Title.IndexOf(towerName, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(card.Description) && card.Description.IndexOf(towerName, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();
        }
    }
}

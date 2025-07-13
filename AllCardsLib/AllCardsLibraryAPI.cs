using AllCardsLib.CardData.Buildings;
using AllCardsLib.CardData.Buffs;
using AllCardsLib.CardData.DOT;
using AllCardsLib.CardData.Monsters;
using AllCardsLib.CardData.Towers;
using CardsShared;
using System.Collections.Generic;
using System.Linq;
using TexturesLib.Shared;

namespace AllCardsLib
{
    public static partial class AllCardsLibAPI
    {
        /// <summary>
        /// Registers all card sets into Plugin.CardDisplayDataCollection.AllCards.
        /// Called by LoadAllCards, do not call directly unless needed.
        /// </summary>
        internal static void RegisterAllCards()
        {
            // Register all Buff cards
            CardsBuffCards.Register();
            CritsBuffCards.Register();
            GoldBuffCards.Register();
            ManaBuffCards.Register();
            TowerBuffCards.Register();
            TreeBuffCards.Register();

            // Register all Buildings cards
            HauntedHouseCards.Register();
            ManaBankCards.Register();
            ManaSiphonCards.Register();
            MineCards.Register();
            UniversityCards.Register();

            // Register all DOT cards
            DOTBleedCards.Register();
            DOTBurnCards.Register();
            DOTPoisonCards.Register();

            // Register all Monsters cards
            GoldDebuffCards.Register();
            MonstersArmorBuffCards.Register();
            MonstersDamageBuffCards.Register();
            MonstersHasteBuffCards.Register();
            MonstersHealthBuffCards.Register();
            MonstersMoveSpeedBuffCards.Register();
            MonstersShieldBuffCards.Register();
            MonstersTowerDamageBuffCards.Register();

            // Register all towers cards
            BallistaCards.Register();
            CannonCards.Register();
            EncampmentCards.Register();
            FlameThrowerCards.Register();
            FrostKeepCards.Register();
            LookoutCards.Register();
            MonumentCards.Register();
            MortarCards.Register();
            ObeliskCards.Register();
            ParticleCannonCards.Register();
            PoisonSprayerCards.Register();
            RadarCards.Register();
            SawbladeCards.Register();
            TeslaCoilCards.Register();
            VampireLairCards.Register();
        }

        public static void LoadAllCards()
        {
            if (Plugin.CardDisplayDataCollection.AllCards.Count == 0)
                RegisterAllCards();

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
            CardCategory? category = null,
            CardAcquisitionType? acquisitionType = null,
            string associatedTowerOrBuilding = null,
            bool? unlocked = null)
        {
            return Plugin.CardDisplayDataCollection.AllCards
                .Where(card =>
                    (category == null || card.Category == category.Value) &&
                    (acquisitionType == null || card.AcquisitionType == acquisitionType.Value) &&
                    (associatedTowerOrBuilding == null || card.AssociatedTowerOrBuilding == associatedTowerOrBuilding) &&
                    (unlocked == null || card.Unlocked == unlocked.Value)
                ).ToList();
        }

        public class CardNode
        {
            public CardDisplayData Card;
            public List<CardNode> Children = new List<CardNode>();
        }

        public static List<CardNode> BuildCardTrees(List<CardDisplayData> cards)
        {
            var lookup = cards.ToDictionary(c => c.UnlockName);
            var reverseLookup = new HashSet<string>(cards.SelectMany(c => c.Unlocks));
            var roots = cards.Where(c => !reverseLookup.Contains(c.UnlockName)).ToList();

            var nodeMap = cards.ToDictionary(
                c => c.UnlockName,
                c => new CardNode { Card = c });

            foreach (var node in nodeMap.Values)
            {
                foreach (var unlock in node.Card.Unlocks)
                {
                    if (nodeMap.TryGetValue(unlock, out var child))
                        node.Children.Add(child);
                }
            }

            return roots.Select(r => nodeMap[r.UnlockName]).ToList();
        }
    }
}

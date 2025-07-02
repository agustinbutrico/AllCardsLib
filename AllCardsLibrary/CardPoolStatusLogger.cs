using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AllCardsLibrary
{
    internal class CardPoolStatusLogger : MonoBehaviour
    {
        void Update()
        {
            // Use F9 to trigger the dump
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Plugin.Log.LogInfo("[AllCardsLibrary] F9 pressed, dumping card data...");
                DumpCards();
            }
        }

        void DumpCards()
        {
            // 1️⃣ Dump availableCards
            var cardManager = FindObjectOfType<CardManager>();
            if (cardManager == null)
            {
                Plugin.Log.LogWarning("CardManager not found in scene.");
                return;
            }

            var availableCards = AccessTools.Field(typeof(CardManager), "availableCards").GetValue(cardManager) as List<UpgradeCard>;
            Plugin.Log.LogInfo("[AllCardsLibrary] ==== AVAILABLE CARDS (Run Pool) ====");
            for (int i = 0; i < availableCards.Count; i++)
                LogCardBasic(availableCards[i], $"[AvailableCard {i}]");

            // 2️⃣ Dump availableMonsterCards
            var availableMonsterCards = AccessTools.Field(typeof(CardManager), "availableMonsterCards").GetValue(cardManager) as List<UpgradeCard>;
            Plugin.Log.LogInfo("[AllCardsLibrary] ==== AVAILABLE MONSTER CARDS ====");
            for (int i = 0; i < availableMonsterCards.Count; i++)
                LogCardBasic(availableMonsterCards[i], $"[AvailableMonsterCard {i}]");

            // 3️⃣ Dump all instantiated UpgradeCards
            UpgradeCard[] allCards = GameObject.FindObjectsOfType<UpgradeCard>();
            Plugin.Log.LogInfo("[AllCardsLibrary] ==== ALL CARDS IN SCENE ====");
            for (int i = 0; i < allCards.Length; i++)
                LogCardBasic(allCards[i], $"[AllCard {i}]");

            Plugin.Log.LogInfo("[AllCardsLibrary] ==== CARD DUMP COMPLETED ====");
        }

        static void LogCardBasic(UpgradeCard card, string prefix)
        {
            if (card == null)
            {
                Plugin.Log.LogInfo($"{prefix} NULL");
                return;
            }

            string title = card.title ?? "(null)";
            string description = card.description ?? "(null)";
            string spriteName = card.image != null ? card.image.name : "(null)";
            string unlockName = (string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "(null)";
            bool unlockedByDefault = (bool)AccessTools.Field(typeof(UpgradeCard), "unlockedByDefault").GetValue(card);
            int playerPrefState = string.IsNullOrEmpty(unlockName) ? -1 : PlayerPrefs.GetInt(unlockName, 0);
            string unlocks = card.unlocks != null && card.unlocks.Count > 0 ? $"[{string.Join(", ", card.unlocks.Select(u => u?.title ?? "(null)"))}]" : "[(none)]";

            Plugin.Log.LogInfo($"{prefix} Title: {title}, Desc: {description}, Sprite: {spriteName}, Unlocked: {card.unlocked}, UnlockedByDefault: {unlockedByDefault}, UnlockName: {unlockName}, PlayerPrefs: {playerPrefState}, Unlocks: {unlocks}");
        }
    }
}

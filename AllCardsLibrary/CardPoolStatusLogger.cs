using BepInEx;
using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace AllCardsLibDebug
{
    internal class CardPoolStatusLogger : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Plugin.Log.LogInfo("[Debug] F9 pressed, logging card data...");
                DumpCards();
            }
        }

        void DumpCards()
        {
            // Instantiate CardManager
            var cardManager = FindObjectOfType<CardManager>();
            if (cardManager == null)
            {
                Plugin.Log.LogWarning("CardManager not found in scene, attempting to dump cards from MainMenu SlidingScreen instead.");
            }

            // Dump availableCards
            var availableCards = AccessTools.Field(typeof(CardManager), "availableCards").GetValue(cardManager) as List<UpgradeCard>;
            Plugin.Log.LogInfo("[Debug] ==== AVAILABLE CARDS ====");
            for (int i = 0; i < availableCards.Count; i++)
                LogCardBasic(availableCards[i], $"[AvailableCard {i}]");

            // Dump availableMonsterCards
            var availableMonsterCards = AccessTools.Field(typeof(CardManager), "availableMonsterCards").GetValue(cardManager) as List<UpgradeCard>;
            Plugin.Log.LogInfo("[Debug] ==== AVAILABLE MONSTER CARDS ====");
            for (int i = 0; i < availableMonsterCards.Count; i++)
                LogCardBasic(availableMonsterCards[i], $"[AvailableMonsterCard {i}]");

            // Dump all instantiated UpgradeCards
            UpgradeCard[] allCards = GameObject.FindObjectsOfType<UpgradeCard>(includeInactive: false);
            Plugin.Log.LogInfo("[Debug] ==== ALL CARDS IN SCENE ====");
            for (int i = 0; i < allCards.Length; i++)
                LogCardBasic(allCards[i], $"[AllCard {i}]");
            Plugin.Log.LogInfo("[Debug] ==== CARD IN SCENE DUMP COMPLETED ====");
        }

        // Helper function if not present
        string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }

        private void LogCardBasic(UpgradeCard card, string prefix)
        {
            if (card == null)
            {
                Plugin.Log.LogInfo($"{prefix} NULL");
                return;
            }

            string title = card.title ?? "(null)";
            string description = card.description ?? "(null)";

            Sprite sprite = card.image;
            string spriteName = sprite != null ? sprite.name : "(null)";

            string unlockName = (string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "(null)";
            bool unlockedByDefault = (bool)AccessTools.Field(typeof(UpgradeCard), "unlockedByDefault").GetValue(card);


            FieldInfo unlockNameField = AccessTools.Field(typeof(UpgradeCard), "unlockName");
            string unlocks = "[(none)]";
            if (card.unlocks != null && card.unlocks.Count > 0)
            {
                var unlockList = card.unlocks.Select(u =>
                {
                    if (u == null) return "(null)";
                    string uUnlockName = (string)unlockNameField.GetValue(u);
                    return uUnlockName ?? "(null)";
                });
                unlocks = "[" + string.Join(", ", unlockList) + "]";
            }

            Plugin.Log.LogInfo($"{prefix} Title: {title}, Description: {description}, Sprite name: {spriteName}, UnlockName: {unlockName}, UnlockedByDefault: {unlockedByDefault}, Unlocked: {card.unlocked}, Unlocks: {unlocks}");
        }
    }
}

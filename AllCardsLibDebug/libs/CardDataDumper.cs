using BepInEx;
using HarmonyLib;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace AllCardsLibDebug
{
    internal class CardDataDumper : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F7))
            {
                Plugin.Log.LogInfo("[Debug] F7 pressed, dumping card data from all UpgradeCards in scene...");
                DumpCards(cardManagerCards: false);
            }
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Plugin.Log.LogInfo("[Debug] F7 pressed, dumping card data from CardManager...");
                DumpCards(cardManagerCards: true);
            }
        }

        void DumpCards(bool cardManagerCards)
        {
            string basePath = Path.Combine(Paths.PluginPath, "AllCardsLib Debug", "DumpedCards");
            Directory.CreateDirectory(basePath);

            List<UpgradeCard> cardsToDump = new List<UpgradeCard>();

            if (cardManagerCards)
            {
                var cardManager = FindObjectOfType<CardManager>();
                if (cardManager == null)
                {
                    Plugin.Log.LogWarning("CardManager not found in scene.");
                }

                var availableCards = AccessTools.Field(typeof(CardManager), "availableCards").GetValue(cardManager) as List<UpgradeCard>;
                var availableMonsterCards = AccessTools.Field(typeof(CardManager), "availableMonsterCards").GetValue(cardManager) as List<UpgradeCard>;

                if (availableCards != null) cardsToDump.AddRange(availableCards);
                if (availableMonsterCards != null) cardsToDump.AddRange(availableMonsterCards);

                basePath = Path.Combine(basePath, "CardManagerCards");
            }
            else
            {
                UpgradeCard[] allCards = GameObject.FindObjectsOfType<UpgradeCard>(includeInactive: true);
                cardsToDump.AddRange(allCards);
                basePath = Path.Combine(basePath, "SceneCards");
            }

            Directory.CreateDirectory(basePath);

            foreach (var card in cardsToDump)
            {
                string safeTitle = SanitizeFileName(card.title);
                string filePath = Path.Combine(basePath, $"{safeTitle}.json");

                var cardData = new
                {
                    card.title,
                    card.description,
                    spriteName = card.image != null ? card.image.name : "(null)",
                    unlockName = (string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "(null)",
                    unlockedByDefault = (bool)AccessTools.Field(typeof(UpgradeCard), "unlockedByDefault").GetValue(card),
                    playerPrefState = PlayerPrefs.GetInt((string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "", -1),
                    unlocks = card.unlocks != null ? card.unlocks.Select(u => u?.title ?? "(null)").ToList() : new List<string>(),
                    card.unlocked
                };

                string json = JsonConvert.SerializeObject(cardData, Formatting.Indented);
                File.WriteAllText(filePath, json);

                Plugin.Log.LogInfo($"[Debug] Dumped card '{card.title}' to '{filePath}'.");
            }

            Plugin.Log.LogInfo($"[Debug] Finished dumping {(cardManagerCards ? "CardManager" : "scene")} cards to disk.");
        }

        string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }
    }
}

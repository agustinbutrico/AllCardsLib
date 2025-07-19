using Microsoft.Win32;
using System;
using System.Linq;
using UnityEngine;

namespace AllCardsLib.Corrections
{
    internal class SyncCardUnclocked
    {
        internal static void SyncCardUnlockedStatus()
        {
            SyncCardUnlockedFromRegistry();

            UpgradeCard[] inSceneCards = UnityEngine.Object.FindObjectsOfType<UpgradeCard>();

            if (inSceneCards == null || inSceneCards.Length == 0)
            {
                return;
            }

            SyncCardUnlockedFromScene();
        }

        private static void SyncCardUnlockedFromScene()
        {
            foreach (var upgradeCard in UnityEngine.Object.FindObjectsOfType<UpgradeCard>())
            {
                string upgradeTitle = upgradeCard.title;
                string upgradeUnlockName = (string)CardsInSceneCorrector.unlockNameField.GetValue(upgradeCard);
                bool upgradeUnlocked = upgradeCard.unlocked;

                var match = Plugin.CardDisplayDataCollection.AllCards
                    .FirstOrDefault(c => c.Title == upgradeTitle && c.UnlockName == upgradeUnlockName);

                if (match != null)
                {
                    match.Unlocked = upgradeUnlocked;
                }
            }
        }

        private static void SyncCardUnlockedFromRegistry()
        {
            const string registryPath = @"Software\Die of Death Games\Rogue Tower";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
            {
                if (key == null)
                {
                    Plugin.Log.LogWarning("Registry path not found: " + registryPath);
                    return;
                }

                string[] valueNames = key.GetValueNames();

                foreach (var card in Plugin.CardDisplayDataCollection.AllCards)
                {
                    if (string.IsNullOrEmpty(card.UnlockName))
                        continue;

                    string matchName = valueNames
                        .FirstOrDefault(name =>
                            name.Contains("_h") &&
                            name.Split(new[] { "_h" }, 2, StringSplitOptions.None)[0] == card.UnlockName);

                    if (matchName != null)
                    {
                        object rawValue = key.GetValue(matchName);

                        if (rawValue is int intValue && intValue == 1)
                        {
                            card.Unlocked = true;
                        }
                    }
                }
            }
        }
    }
}

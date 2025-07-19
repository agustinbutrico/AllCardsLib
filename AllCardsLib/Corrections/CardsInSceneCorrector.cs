using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace AllCardsLib.Corrections
{
    internal class CardsInSceneCorrector
    {
        private int researchBreakthroughCounter = 0;
        internal static readonly FieldInfo unlockNameField = AccessTools.Field(typeof(UpgradeCard), "unlockName");
        private static readonly Dictionary<string, UpgradeCard> cardsMissingDependency = new Dictionary<string, UpgradeCard>();

        internal void CorrectGameSceneCards()
        {
            UpgradeCard[] inSceneCards = UnityEngine.Object.FindObjectsOfType<UpgradeCard>();

            if (inSceneCards == null || inSceneCards.Length == 0)
            {
                Plugin.Log.LogWarning("No UpgradeCard objects found in the scene.");
                return;
            }

            Plugin.Log.LogDebug($"Found {inSceneCards.Length} UpgradeCard objects in the scene.");
            Plugin.Log.LogDebug($"Found {Plugin.CardDisplayDataCollection.AllCards.Count} cards in AllCards.");

            researchBreakthroughCounter = 0;

            foreach (UpgradeCard card in inSceneCards)
            {
                try
                {
                    CorrectGameSceneCard(card);
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogError($"Exception while processing card '{card?.name}': {ex}");
                }
            }
            AttachMissingDependencies();

            SyncCardUnclocked.SyncCardUnlockedStatus();
        }

        private void CorrectGameSceneCard(UpgradeCard card)
        {
            if (!string.IsNullOrEmpty(card.description) && card.description.EndsWith("."))
            {
                card.description = card.description.Substring(0, card.description.Length - 1);
            }

            string currentUnlockName = (string)unlockNameField.GetValue(card) ?? "";

            // Handle Research Breakthrough! separately
            if (card.title == "Research Breakthrough!" && currentUnlockName == "University")
            {
                researchBreakthroughCounter++;

                string researchUnlockName = null;
                if (researchBreakthroughCounter == 1)
                    researchUnlockName = "Research1";
                else if (researchBreakthroughCounter == 2)
                    researchUnlockName = "Research2";
                else if (researchBreakthroughCounter == 3)
                    researchUnlockName = "Research3";

                if (researchUnlockName != null)
                {
                    unlockNameField.SetValue(card, researchUnlockName);
                }
                else
                {
                    Plugin.Log.LogWarning($"Extra Research Breakthrough! card found beyond 3 instances.");
                }

                return; // Skip further processing
            }

            if (unlockNameCorrections.TryGetValue((card.title, currentUnlockName), out string correctedUnlockName))
            {
                unlockNameField.SetValue(card, correctedUnlockName);
            }

            if (titleCorrections.TryGetValue(card.title, out string cleanTitle))
            {
                card.title = cleanTitle;
            }

            if ((currentUnlockName == "GlobalCritLevel2" || currentUnlockName == "Frugal6" || currentUnlockName == "MonsterDestruction2" || currentUnlockName == "MonsterDestruction3")
                && !cardsMissingDependency.ContainsKey(currentUnlockName))
            {
                cardsMissingDependency.Add(currentUnlockName, card);
            }
        }

        private static readonly Dictionary<(string title, string unlockName), string> unlockNameCorrections =
            new Dictionary<(string, string), string>
        {
            { ("Round Shot I", "ObeliskArmor1"), "CannonArmor1" },
            { ("Round Shot II", "ObeliskArmor2"), "CannonArmor2" },
            { ("Round Shot III", "ObeliskArmor3"), "CannonArmor3" },
            { ("Area of Effect III", "MortarBlast2"), "MortarBlast3" },
            { ("Dark Night I", "ParticleCannonHealth1"), "VampireLairHealth1" },
            { ("Dark Night II", "ParticleCannonHealth2"), "VampireLairHealth2" },
            { ("Dark Night III", "ParticleCannonHealth3"), "VampireLairHealth3" },
            { ("Gothic Horror", "ParticleCannonDamage1"), "VampireLairDamage1" },
            { ("Feast II", "ParticleCannonBleed2"), "VampireLairBleed2" },
            { ("Slow Cooker II", "BurnSpeed"), "BurnSpeed1" },
            { ("Seance I", "HauntedHouse"), "Seance1" },
            { ("Seance II", "HauntedHouse"), "Seance2" },
            { ("Seance III", "HauntedHouse"), "Seance3" },
            { ("Savings Account I", "ManaBank"), "Savings1" },
            { ("Savings Account II", "ManaBank"), "Savings2" },
            { ("Building - Mana Siphon", ""), "ManaSiphon" },
            { ("Gold Rush!", "Mine"), "GoldRush" },
            { ("Scholarships I", "University"), "Scholarships1" },
            { ("Scholarships II", "University"), "Scholarships2" },
            { ("Scholarships III", "University"), "Scholarships3" },
            { ("Sorcery I", "ManaGen1"), "Sourcery1" },
            { ("Sorcery II", "ManaGen2"), "Sourcery2" },
            { ("Sorcery III", "ManaGen3"), "Sourcery3" },
            { ("Life Steal I", "ManaGen1"), "LifeSteal1" },
            { ("Life Steal II", "ManaGen2"), "LifeSteal2" },
            { ("Life Steal III", "ManaGen3"), "LifeSteal3" },
            { ("Fortification I", "TowerHealth1"), "Fortification1" },
            { ("Fortification II", "TowerHealth4"), "Fortification2" },
            { ("Fortification III", "TowerHealth7"), "Fortification3" },
            { ("Fortification IV", "TowerHealth10"), "Fortification4" },
            { ("Frugal I", ""), "Frugal1" },
            { ("Frugal II", ""), "Frugal2" },
            { ("Frugal III", ""), "Frugal3" },
            { ("Frugal IV", ""), "Frugal4" },
            { ("Frugal V", ""), "Frugal5" },
            { ("Frugal VI", ""), "Frugal6" },
            { ("Monster Armor I", ""), "MonsterArmor1" },
            { ("Monster Armor II", ""), "MonsterArmor2" },
            { ("Monster Armor III", ""), "MonsterArmor3" },
            { ("Monster Armor IV", ""), "MonsterArmor4" },
            { ("Monster Armor V", ""), "MonsterArmor5" },
            { ("Monster Armor VI", ""), "MonsterArmor6" },
            { ("Monster Armor VII", ""), "MonsterArmor7" },
            { ("Monster Armor VIII", ""), "MonsterArmor8" },
            { ("Monster Armor IX", ""), "MonsterArmor9" },
            { ("Monster Armor X", ""), "MonsterArmor10" },
            { ("Monster Armor XI", ""), "MonsterArmor11" },
            { ("Monster Armor XII", ""), "MonsterArmor12" },
            { ("Monster Armor XIII", ""), "MonsterArmor13" },
            { ("Monster Armor XIV", ""), "MonsterArmor14" },
            { ("Monster Armor XV", ""), "MonsterArmor15" },
            { ("Monster Armor XVI", ""), "MonsterArmor16" },
            { ("Monster Armor XVII", ""), "MonsterArmor17" },
            { ("Monster Armor XVIII", ""), "MonsterArmor18" },
            { ("Monster Armor XIX", ""), "MonsterArmor19" },
            { ("Monster Armor XX", ""), "MonsterArmor20" },
            { ("Destruction I", ""), "MonsterDestruction1" },
            { ("Destruction II", ""), "MonsterDestruction2" },
            { ("Destruction III", ""), "MonsterDestruction3" },
            { ("Quickness I", ""), "MonsterQuickness1" },
            { ("Quickness II", ""), "MonsterQuickness2" },
            { ("Quickness III", ""), "MonsterQuickness3" },
            { ("Quickness IV", ""), "MonsterQuickness4" },
            { ("Monster Health I", ""), "MonsterHealth1" },
            { ("Monster Health II", ""), "MonsterHealth2" },
            { ("Monster Health III", ""), "MonsterHealth3" },
            { ("Monster Health IV", ""), "MonsterHealth4" },
            { ("Monster Health V", ""), "MonsterHealth5" },
            { ("Monster Health VI", ""), "MonsterHealth6" },
            { ("Monster Health VII", ""), "MonsterHealth7" },
            { ("Monster Health VIII", ""), "MonsterHealth8" },
            { ("Monster Health IX", ""), "MonsterHealth9" },
            { ("Monster Health X", ""), "MonsterHealth10" },
            { ("Monster Health XI", ""), "MonsterHealth11" },
            { ("Monster Health XII", ""), "MonsterHealth12" },
            { ("Monster Health XIII", ""), "MonsterHealth13" },
            { ("Monster Health XIV", ""), "MonsterHealth14" },
            { ("Monster Health XV", ""), "MonsterHealth15" },
            { ("Monster Health XVI", ""), "MonsterHealth16" },
            { ("Monster Health XVII", ""), "MonsterHealth17" },
            { ("Monster Health XVIII", ""), "MonsterHealth18" },
            { ("Monster Health XIX", ""), "MonsterHealth19" },
            { ("Monster Health XX", ""), "MonsterHealth20" },
            { ("Speed I", ""), "MonsterSpeed1" },
            { ("Speed II", ""), "MonsterSpeed2" },
            { ("Speed III", ""), "MonsterSpeed3" },
            { ("Speed IV", ""), "MonsterSpeed4" },
            { ("Speed V", ""), "MonsterSpeed5" },
            { ("Speed VI", ""), "MonsterSpeed6" },
            { ("Speed VII", ""), "MonsterSpeed7" },
            { ("Speed VIII", ""), "MonsterSpeed8" },
            { ("Speed IX", ""), "MonsterSpeed9" },
            { ("Speed X", ""), "MonsterSpeed10" },
            { ("Speed XI", ""), "MonsterSpeed11" },
            { ("Speed XII", ""), "MonsterSpeed12" },
            { ("Speed XIII", ""), "MonsterSpeed13" },
            { ("Speed XIV", ""), "MonsterSpeed14" },
            { ("Speed XV", ""), "MonsterSpeed15" },
            { ("Perserverance I", ""), "MonsterPerserverance1" },
            { ("Perserverance II", ""), "MonsterPerserverance2" },
            { ("Perserverance III", ""), "MonsterPerserverance3" },
            { ("Perserverance IV", ""), "MonsterPerserverance4" },
            { ("Perserverance V", ""), "MonsterPerserverance5" },
            { ("Perserverance VI", ""), "MonsterPerserverance6" },
            { ("Monster Shields I", ""), "MonsterShields1" },
            { ("Monster Shields II", ""), "MonsterShields2" },
            { ("Monster Shields III", ""), "MonsterShields3" },
            { ("Monster Shields IV", ""), "MonsterShields4" },
            { ("Monster Shields V", ""), "MonsterShields5" },
            { ("Monster Shields VI", ""), "MonsterShields6" },
            { ("Monster Shields VII", ""), "MonsterShields7" },
            { ("Monster Shields VIII", ""), "MonsterShields8" },
            { ("Monster Shields IX", ""), "MonsterShields9" },
            { ("Monster Shields X", ""), "MonsterShields10" },
            { ("Monster Shields XI", ""), "MonsterShields11" },
            { ("Monster Shields XII", ""), "MonsterShields12" },
            { ("Monster Shields XIII", ""), "MonsterShields13" },
            { ("Monster Shields XIV", ""), "MonsterShields14" },
            { ("Monster Shields XV", ""), "MonsterShields15" },
            { ("Monster Shields XVI", ""), "MonsterShields16" },
            { ("Monster Shields XVII", ""), "MonsterShields17" },
            { ("Monster Shields XVIII", ""), "MonsterShields18" },
            { ("Monster Shields XIX", ""), "MonsterShields19" },
            { ("Monster Shields XX", ""), "MonsterShields20" },
            { ("Protection I", ""), "MonsterProtection1" },
            { ("Protection II", ""), "MonsterProtection2" },
            { ("Protection III", ""), "MonsterProtection3" },
            { ("Protection IV", ""), "MonsterProtection4" },
            { ("Protection V", ""), "MonsterProtection5" },
            { ("Protection VI", ""), "MonsterProtection6" },
            { ("Protection VII", ""), "MonsterProtection7" },
            { ("Protection VIII", ""), "MonsterProtection8" },
            { ("Tower - Tesla Coil", ""), "TeslaCoil" },
        };

        private static readonly Dictionary<string, string> titleCorrections = new Dictionary<string, string>
        {
            { "Building - Mana Siphon", "Mana Siphon" },
            { "Tower - Cannon", "Cannon" },
            { "Tower - Encampment", "Encampment" },
            { "Tower - Flame Thrower", "Flame Thrower" },
            { "Tower - Frost Keep", "Frost Keep" },
            { "Tower - Lookout", "Lookout" },
            { "Tower - Monument", "Monument" },
            { "Tower - Mortar", "Mortar" },
            { "Tower - Obelisk", "Obelisk" },
            { "Tower - Particle Cannon", "Particle Cannon" },
            { "Tower - Poison Sprayer", "Poison Sprayer" },
            { "Tower - Radar", "Radar" },
            { "Tower - Shredder", "Shredder" },
            { "Tower - Tesla Coil", "Tesla Coil" },
            { "Tower - Vampire Lair", "Vampire Lair" },
            { "Building - Haunted House", "Haunted House" },
            { "Building - Mana Bank", "Mana Bank" },
            { "Building - Mine", "Mine" },
            { "Building - University", "University" },
            { "Ricochet ", "Ricochet" },
            { "Quality over Quantity", "Quality over Quantity I" },
            { "Pyrochemistry I", "Fuel Saturation I" },
            { "Pyrochemistry II", "Fuel Saturation II" },
            { "Pyrochemistry III", "Fuel Saturation III" },
            { "Pyrochemistry IV", "Fuel Saturation IV" },
            { "Immolation", "Pyrochemistry" },
            { "Fumes I", "Fumigation I" },
            { "Fumes II", "Fumigation II" },
            { "Fumes III", "Fumigation III" },
        };

        private void AttachDependency(string parentUnlockName, string childUnlockName)
        {
            foreach (var card in UnityEngine.Object.FindObjectsOfType<UpgradeCard>())
            {
                if ((string)unlockNameField.GetValue(card) == parentUnlockName &&
                    cardsMissingDependency.TryGetValue(childUnlockName, out UpgradeCard childCard))
                {
                    if (card.unlocks == null)
                        card.unlocks = new List<UpgradeCard>();

                    if (!card.unlocks.Contains(childCard))
                    {
                        card.unlocks.Add(childCard);
                    }
                }
            }
        }

        private void AttachMissingDependencies()
        {
            AttachDependency("GlobalCritLevel1", "GlobalCritLevel2");
            AttachDependency("Frugal5", "Frugal6");
            AttachDependency("MonsterDestruction1", "MonsterDestruction2");
            AttachDependency("MonsterDestruction2", "MonsterDestruction3");
        }

        internal void CorrectMainMenuCards()
        {
            Transform teslaCoil = GameObject.Find("Canvas/UpgradeMenu/SlidingScreen/TeslaCoil")?.transform;

            if (teslaCoil != null)
            {
                foreach (Transform child in teslaCoil)
                {
                    if (child.name.Contains("HealthDamage1") && child.name.EndsWith("(2)"))
                    {
                        Transform titleTransform = child.Find("Title");
                        if (titleTransform != null)
                        {
                            Text titleText = titleTransform.GetComponent<Text>();
                            if (titleText != null)
                            {
                                titleText.text = "Power Surge III";
                            }
                            else
                            {
                                Plugin.Log.LogWarning($"Text component not found on {child.name}/Title");
                            }
                        }
                    }
                }
            }
        }
    }
}

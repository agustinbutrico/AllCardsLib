using AllCardsLib.Corrections;
using BepInEx;
using CardsShared;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AllCardsLib
{
    [BepInPlugin("AgusBut.AllCardsLib", "AllCardsLib", "1.0.0")]
    [BepInDependency("AgusBut.TexturesLib.Shared")]
    [BepInDependency("AgusBut.CardsTexturesLib")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }
        public static BepInEx.Logging.ManualLogSource Log { get; private set; }

        public static class CardDisplayDataCollection
        {
            public static List<CardDisplayData> AllCards { get; } = new List<CardDisplayData>();
        }

        public static event Action OnCardSyncComplete;
        internal static void RaiseOnCardSyncComplete()
        {
            OnCardSyncComplete?.Invoke();
        }

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            var harmony = new Harmony("AgusBut.AllCardsLib");
            harmony.PatchAll();

            AllCardsLibAPI.LoadAllCards(); // Always needed for card data

            SceneManager.activeSceneChanged += OnActiveSceneChanged;

            Logger.LogInfo("AllCardsLib loaded successfully.");
        }

        private void OnActiveSceneChanged(Scene oldScene, Scene newScene)
        {
            if (newScene.name == "GameScene")
            {
                CardsInSceneCorrector corrector = new CardsInSceneCorrector();
                corrector.CorrectGameSceneCards();

                RaiseOnCardSyncComplete();
            }

            if (newScene.name == "MainMenu")
            {
                Instance.StartCoroutine(WaitThenCorrectMainMenuCards());
            }
        }

        private IEnumerator WaitThenCorrectMainMenuCards()
        {
            while (GameObject.Find("Canvas/UpgradeMenu/SlidingScreen") == null)
                yield return null;

            CardsInSceneCorrector corrector = new CardsInSceneCorrector();
            corrector.CorrectMainMenuCards();
            UpgradeButtonFixer.FixAllButtons();
        }
    }
}

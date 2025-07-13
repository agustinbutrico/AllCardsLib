using BepInEx;
using CardsShared;
using HarmonyLib;
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

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            var harmony = new Harmony("AgusBut.AllCardsLib");
            harmony.PatchAll();

            AllCardsLibAPI.LoadAllCards(); // Always needed for card data

            SceneManager.sceneLoaded += OnSceneLoaded; // Add correction on scene load

            Logger.LogInfo("AllCardsLib loaded successfully.");
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "GameScene")
            {
                CardsInSceneCorrector corrector = new CardsInSceneCorrector();
                corrector.CorrectGameSceneCards();
            }

            if (scene.name == "MainMenu")
            {
                Plugin.Instance.StartCoroutine(WaitThenCorrectMainMenuCards());
            }
        }


        private IEnumerator WaitThenCorrectMainMenuCards()
        {
            while (GameObject.Find("Canvas/UpgradeMenu/SlidingScreen") == null)
                yield return null;

            CardsInSceneCorrector corrector = new CardsInSceneCorrector();
            corrector.CorrectMainMenuCards();
        }

        private void OnDestroy()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}

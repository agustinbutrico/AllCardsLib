using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace AllCardsLibrary
{
    [BepInPlugin("com.AgusBut.allcardslibrary", "AllCardsLibrary", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }
        public static BepInEx.Logging.ManualLogSource Log { get; private set; }

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            var harmony = new Harmony("AgusBut.BetterPauseMenu");
            harmony.PatchAll();

            // Attach the CardPoolStatusLogger with hotkey trigger
            GameObject obj = new GameObject("CardPoolStatusLogger");
            obj.AddComponent<CardPoolStatusLogger>();
            DontDestroyOnLoad(obj);

            // Attach the CardDataDumper with hotkey support
            GameObject dumperObj = new GameObject("CardDataDumper");
            dumperObj.AddComponent<CardDataDumper>();
            DontDestroyOnLoad(dumperObj);
        }
    }
}

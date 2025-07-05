using BepInEx;
using HarmonyLib;

namespace AllCardsLibrary
{
    [BepInPlugin("AgusBut.AllCardsLibrary", "AllCardsLibrary", "1.0.0")]
    [BepInDependency("AgusBut.AT2DLib.Cards")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }
        public static BepInEx.Logging.ManualLogSource Log { get; private set; }

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            var harmony = new Harmony("AgusBut.AllCardsLibrary");
            harmony.PatchAll();

            AllCardsLibraryAPI.LoadAllCards(); // Always needed for card data
        }
    }
}

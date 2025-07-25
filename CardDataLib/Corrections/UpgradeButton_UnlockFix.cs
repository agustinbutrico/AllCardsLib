using HarmonyLib;

namespace CardDataLib.Corrections
{
    [HarmonyPatch(typeof(UpgradeButton), nameof(UpgradeButton.Unlock))]
    class UpgradeButton_UnlockFix
    {
        static readonly AccessTools.FieldRef<UpgradeButton, string> unlockStringRef =
            AccessTools.FieldRefAccess<UpgradeButton, string>("unlockString");

        static void Prefix(UpgradeButton __instance)
        {
            if (UnlockNameCorrector.TryCorrect(__instance, out var corrected))
            {
                unlockStringRef(__instance) = corrected;
            }
        }
    }
}
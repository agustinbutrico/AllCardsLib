using HarmonyLib;
using UnityEngine;

namespace CardDataLib.Corrections
{
    internal static class UpgradeButtonFixer
    {
        static readonly AccessTools.FieldRef<UpgradeButton, string> unlockStringRef =
            AccessTools.FieldRefAccess<UpgradeButton, string>("unlockString");

        internal static void FixAllButtons()
        {
            var screen = GameObject.Find("Canvas/UpgradeMenu/SlidingScreen");
            if (screen == null)
            {
                Plugin.Log.LogError("❌ Could not find SlidingScreen.");
                return;
            }

            foreach (Transform towerT in screen.transform)
            {
                string tower = towerT.name;

                if (tower != "VampireLair" && tower != "Monument" && tower != "ParticleCannon")
                    continue;

                foreach (Transform upgradeTypeT in towerT)
                {
                    string upgradeType = upgradeTypeT.name;

                    var btn = upgradeTypeT.GetComponent<UpgradeButton>();
                    if (btn == null)
                    {
                        Plugin.Log.LogError($"❌ No UpgradeButton on: {upgradeTypeT.GetHierarchyPath()}");
                        continue;
                    }

                    if (UnlockNameCorrector.TryCorrect(btn, out var corrected))
                    {
                        unlockStringRef(btn) = corrected;
                    }
                }
            }
        }

        internal static string GetHierarchyPath(this Transform current)
        {
            string path = current.name;
            while (current.parent != null)
            {
                current = current.parent;
                path = current.name + "/" + path;
            }
            return path;
        }
    }
}
namespace CardDataLib.Corrections
{
    internal static class UnlockNameCorrector
    {
        internal static bool TryCorrect(UpgradeButton button, out string corrected)
        {
            corrected = null;

            var upgradeTypeT = button.transform;
            var towerT = upgradeTypeT?.parent;

            string upgradeType = upgradeTypeT?.name;
            string tower = towerT?.name;

            if (string.IsNullOrEmpty(tower) || string.IsNullOrEmpty(upgradeType))
                return false;

            if (tower == "VampireLair" || tower == "Monument" || tower == "ParticleCannon")
            {
                if (upgradeType.StartsWith("ArmorDamage"))
                {
                    int variant = upgradeType.EndsWith(" (2)") ? 3 :
                                  upgradeType.EndsWith(" (1)") ? 2 : 1;

                    corrected = $"{tower}Armor{variant}";
                    return true;
                }
            }

            return false;
        }
    }
}

using CardDataLib.CardData.Buffs;
using CardDataLib.CardData.Buildings;
using CardDataLib.CardData.DOT;
using CardDataLib.CardData.Monsters;
using CardDataLib.CardData.Towers;

namespace CardDataLib.CardData
{
    internal class CardsRegisterManager
    {
        internal static void RegisterAllCards()
        {
            // Register all Buff cards
            DrawBuffCards.Register();
            GoldBuffCards.Register();
            ManaBuffCards.Register();
            CritsBuffCards.Register();
            TowerBuffCards.Register();
            TreeBuffCards.Register();

            // Register all Buildings cards
            ManaSiphonCards.Register();
            MineCards.Register();
            ManaBankCards.Register();
            HauntedHouseCards.Register();
            UniversityCards.Register();

            // Register all DOT cards
            DOTBleedCards.Register();
            DOTBurnCards.Register();
            DOTPoisonCards.Register();

            // Register all Monsters cards
            MonstersHealthBuffCards.Register();
            MonstersArmorBuffCards.Register();
            MonstersShieldBuffCards.Register();
            MonstersDamageBuffCards.Register();
            MonstersMoveSpeedBuffCards.Register();
            MonstersSlowDebuffCards.Register();
            MonstersHasteBuffCards.Register();
            MonstersGoldDebuffCards.Register();
            MonstersTowerDamageBuffCards.Register();

            // Register all Towers cards
            BallistaCards.Register();
            MortarCards.Register();
            TeslaCoilCards.Register();
            FrostKeepCards.Register();
            FlameThrowerCards.Register();
            PoisonSprayerCards.Register();
            SawbladeCards.Register();
            EncampmentCards.Register();
            LookoutCards.Register();
            VampireLairCards.Register();
            CannonCards.Register();
            MonumentCards.Register();
            RadarCards.Register();
            ObeliskCards.Register();
            ParticleCannonCards.Register();
        }
    }
}

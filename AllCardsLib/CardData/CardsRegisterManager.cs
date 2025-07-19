using AllCardsLib.CardData.Buffs;
using AllCardsLib.CardData.Buildings;
using AllCardsLib.CardData.DOT;
using AllCardsLib.CardData.Monsters;
using AllCardsLib.CardData.Towers;

namespace AllCardsLib.CardData
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

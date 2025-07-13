using System.Collections.Generic;
using UnityEngine;

namespace CardsShared
{
    public enum CardCategory { Buff, Building, DOT, Monster, Tower }
    public enum CardAcquisitionType { AlwaysInRun, StoreUnlocksInRun, StoreAppliesPermanent }

    public class CardDisplayData
    {
        public string Title;
        public string Description;
        public string SpriteName;
        public Sprite Sprite;
        public string UnlockName;
        public bool UnlockedByDefault;
        public bool Unlocked;
        public List<string> Unlocks;
        public CardCategory Category;
        public CardAcquisitionType AcquisitionType;
        public string AssociatedTowerOrBuilding;
    }
}

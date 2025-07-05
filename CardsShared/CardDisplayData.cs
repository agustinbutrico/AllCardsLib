using System.Collections.Generic;
using UnityEngine;

namespace CardsShared
{
    public class CardDisplayData
    {
        public string Title;
        public string Description;
        public string SpriteName;
        public string SpriteBase64;
        public Texture2D SpriteTexture;
        public string UnlockName;
        public bool UnlockedByDefault;
        public int PlayerPrefState;
        public List<string> Unlocks;
        public bool Unlocked;
    }
}

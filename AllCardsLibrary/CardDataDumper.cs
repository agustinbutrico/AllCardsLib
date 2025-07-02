using BepInEx;
using HarmonyLib;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

namespace AllCardsLibrary
{
    internal class CardDataDumper : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                Plugin.Log.LogInfo("[AllCardsLibrary] F10 pressed, dumping all card data to disk...");
                DumpAllCardData();
            }
        }

        void DumpAllCardData()
        {
            UpgradeCard[] allCards = GameObject.FindObjectsOfType<UpgradeCard>();
            string basePath = Path.Combine(Paths.PluginPath, "AllCardsLibrary", "DumpedCards");
            Directory.CreateDirectory(basePath);

            foreach (var card in allCards)
            {
                if (card == null || card.title == null) continue;

                string safeTitle = SanitizeFileName(card.title);
                string cardDir = Path.Combine(basePath, safeTitle);
                Directory.CreateDirectory(cardDir);

                // === 1️⃣ Dump Metadata JSON ===
                var cardData = new
                {
                    title = card.title,
                    description = card.description,
                    spriteName = card.image?.name ?? "(null)",
                    unlockName = (string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "(null)",
                    unlockedByDefault = (bool)AccessTools.Field(typeof(UpgradeCard), "unlockedByDefault").GetValue(card),
                    playerPrefState = PlayerPrefs.GetInt((string)AccessTools.Field(typeof(UpgradeCard), "unlockName").GetValue(card) ?? "", -1),
                    unlocks = card.unlocks != null ? card.unlocks.Select(u => u?.title ?? "(null)").ToList() : new List<string>(),
                    unlocked = card.unlocked
                };

                string json = JsonConvert.SerializeObject(cardData, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(Path.Combine(cardDir, "metadata.json"), json);

                // === 2️⃣ Dump PNG Image ===
                Sprite sprite = card.image;
                if (sprite != null)
                {
                    try
                    {
                        DumpSpriteToPngUsingRenderTexture(sprite, Path.Combine(cardDir, "sprite.png"));

                    }
                    catch (System.Exception ex)
                    {
                        Plugin.Log.LogWarning($"[AllCardsLibrary] Failed to dump sprite for '{sprite.name}': {ex.Message}");
                    }
                }
            }

            Plugin.Log.LogInfo("[AllCardsLibrary] Finished dumping all card data to disk.");
        }

        Texture2D GetTextureFromSprite(Sprite sprite)
        {
            // Try to use sprite.texture if available
            try
            {
                return sprite.texture;
            }
            catch
            {
                Plugin.Log.LogWarning($"[AllCardsLibrary] sprite.texture not accessible for '{sprite.name}', attempting fallback.");
                // Attempt to fallback, but many times you will need to manually extract
                return null;
            }
        }

        string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }

        void DumpSpriteToPngUsingRenderTexture(Sprite sprite, string path)
        {
            int width = (int)sprite.rect.width;
            int height = (int)sprite.rect.height;

            RenderTexture rt = RenderTexture.GetTemporary(width, height, 0);
            RenderTexture.active = rt;

            // Setup
            Texture2D readableTexture = new Texture2D(width, height, TextureFormat.ARGB32, false);
            GL.Clear(true, true, Color.clear);

            // Draw the sprite onto the RenderTexture
            Shader shader = Shader.Find("Sprites/Default");
            if (shader == null)
            {
                Plugin.Log.LogWarning($"[AllCardsLibrary] Cannot find Sprites/Default shader. Skipping sprite dump for '{sprite.name}'.");
                return;
            }
            Material mat = new Material(shader);
            Graphics.Blit(sprite.texture, rt, mat);

            readableTexture.ReadPixels(new Rect((int)sprite.textureRect.x, (int)sprite.textureRect.y, width, height), 0, 0);
            readableTexture.Apply();

            // Encode and save
            byte[] pngData = ImageConversion.EncodeToPNG(readableTexture);
            if (pngData != null)
            {
                File.WriteAllBytes(path, pngData);
            }

            // Cleanup
            RenderTexture.active = null;
            RenderTexture.ReleaseTemporary(rt);
            Destroy(readableTexture);
            Destroy(mat);
        }
    }
}

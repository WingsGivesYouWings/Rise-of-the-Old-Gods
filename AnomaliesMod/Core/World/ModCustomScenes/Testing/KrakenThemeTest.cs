using Terraria;
using Terraria.ModLoader;

namespace AnomaliesMod.Core.World.ModCustomScenes.Testing
{
    public class KrakenThemeTest : ModSceneEffect
    {
        /// <summary>
        /// This scene only serve the purpose of testing if Krarken's theme loops properly. 
        /// Afterwards it must be restructured into the Kraken battle scene 
        /// </summary>
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Sounds/Music/Testing/Kraken");
                                                                                                
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

        public override void Load()
        {
            string krakenMusicPath = "Assets/Sounds/Music/Testing/Kraken";
        }

        public override bool IsSceneEffectActive(Player player)
        {
            return KrakenthemeTestSystem.IsKrakenThemeAcctive;
        }
    }
}

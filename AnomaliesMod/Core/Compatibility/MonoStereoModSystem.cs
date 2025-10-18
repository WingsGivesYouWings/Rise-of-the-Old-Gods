using Terraria.ModLoader;

namespace AnomaliesMod.Core.Compatibility
{  
    public class MonoStereoModSystem : ModSystem
    {
        /// <summary>
        /// Cross-compatibility helper for MonoStereoMod
        /// This is a mod that adds MonoStereo from MonoGame to tModLoader
        /// The idea is repleacing most part of FAudio utilities with this
        /// For more info: https://github.com/NycroV/MonoStereoMod/blob/master/docs/USAGE.md
        /// </summary>
        /// 
        public const string ModName = "MonoStereoMod";

        public static Mod MonoStereoMod
        {
            get;
            private set;
        }

        public static bool IsEnabled => ModLoader.TryGetMod(ModName, out _);

        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod(ModName, out Mod monoStereo)) MonoStereoMod = monoStereo;
        }
    }
}

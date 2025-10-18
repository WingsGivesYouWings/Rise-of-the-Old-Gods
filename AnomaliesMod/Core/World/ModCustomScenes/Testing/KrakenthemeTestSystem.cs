using Terraria.ModLoader;

namespace AnomaliesMod.Core.World.ModCustomScenes.Testing
{
    public class KrakenthemeTestSystem : ModSystem
    {
          public static bool IsKrakenThemeAcctive
          {
             get;
             set;
          }

        public override void ClearWorld() => IsKrakenThemeAcctive = false;
    }
}

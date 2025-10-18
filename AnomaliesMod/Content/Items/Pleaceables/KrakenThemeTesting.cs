using AnomaliesMod.Core.World.ModCustomScenes.Testing;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnomaliesMod.Content.Items.Pleaceables
{
    /// <summary>
    /// This class must be removed once Kraken's theme will be tested
    /// </summary>
    public class KrakenThemeTesting : ModItem
    {
        public override string Texture => TexturesPath("Items", Name);

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 1;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 50;
            Item.useAnimation = 10;
            Item.consumable = false;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
        }

        public override bool? UseItem(Player player)
        {
            if (KrakenthemeTestSystem.IsKrakenThemeAcctive)
            {
                KrakenthemeTestSystem.IsKrakenThemeAcctive = !KrakenthemeTestSystem.IsKrakenThemeAcctive;
                Main.NewText("Finishing Kraken theme test", Color.Red);
                return true;
            }
            KrakenthemeTestSystem.IsKrakenThemeAcctive = !KrakenthemeTestSystem.IsKrakenThemeAcctive;
            Main.NewText("Starting Kraken theme test", Color.Blue);
            return true;
        }
    }
}

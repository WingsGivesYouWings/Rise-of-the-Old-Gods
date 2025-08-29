using Microsoft.Xna.Framework;
using RiseofTheOldGods.Content.Subworlds;
using SubworldLibrary;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace RiseofTheOldGods.Content.Items;

public class MirrorMirror : ModItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.MagicMirror}";
    

    public override void SetDefaults()
    {
        Item.maxStack = 1;
        Item.rare = ItemRarityID.Blue;
        Item.consumable = false;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.UseSound = SoundID.Item50; // Magic Mirror sound
        Item.useTime = 30;
        Item.useAnimation = 30;
        Item.color = Color.Gray;
        
        

    }

    public override bool? UseItem(Player player)
    {
        if(!SubworldSystem.IsActive<TestSubworld>())
        {
            SubworldSystem.Enter<TestSubworld>();
        }
        else
        {
            SubworldSystem.Exit();
        }
        
        return true;
    }

    // Can be crafted any time, requires nothing
    public override void AddRecipes()
    {
        CreateRecipe()
            .Register();
    }
}
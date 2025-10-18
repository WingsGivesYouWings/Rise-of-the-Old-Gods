using Terraria.ModLoader;

namespace AnomaliesMod.Core.Textures
{
  
    public static partial class UtilsClass 
    {   
        private const string texturesDirectory = "AnomaliesMod/Assets/Textures/";   //Selfe explainatory
 
        /// <summary>
        /// Returns the path to a terget asset inside the textures directory
        /// NOTE: For this to work, the class name must match the 
        /// </summary>

        public static string TexturesPath(string targetFolder, string assetName) =>
            $"{texturesDirectory}{targetFolder}/{assetName}";
    }
}

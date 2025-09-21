using System;
using System.Collections.Generic;

namespace RiseoftheGods.Core
{
    public static class TexturesLoader
    {
        ///<summary>
        ///    This class finds the path to a desire texture asset inside the Assets/Textures directory. It takes a string value with the name of the target folder inside 
        ///    and the Type name value of the class that will use the target asset.
        ///    NOTE: IT CAN ONLY WORK IF BOTH ASSETS AND CLASSES HAVE THE SAME NAME
        ///<summary/>

        private const string texturesDirctory = "RiseoftheGods/Assets/Textures/";   //Selfe explainatory

        private static readonly Dictionary<Type, string> TexturesCache = new();   //A cache dictionary. It's particularly useful in cases when the same asset is loaded multiple times

        public static string TexturesPathSolver(Type type, string targetTexturesFolder)
        {
            if(!TexturesCache.TryGetValue(type, out var path)) 
            {
                var textureName = type.Name;
                path = $"{texturesDirctory}{targetTexturesFolder}/{textureName}";
                TexturesCache[type] = path;
            }
            return path;
        }  
    }
}

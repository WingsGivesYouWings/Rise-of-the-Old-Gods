using ReLogic.Utilities;
using Terraria.Audio;

namespace AnomaliesMod.Core.Utilities
{ 
    public static partial class UtilsClass
    {
        /// <summary>
        /// Utility for adjusting the volume of a specific sound slot instance,
        /// allowing values defined by the mod loader beyond standard sound engine limits.
        ///     <param name="soundSlot"> The target sound slot </param>
        ///     <param name="amplificationValue"> The volume amplification factor </param> 
        /// </summary>

        public static SlotId WithVolumeAmplification(this SlotId soundSlot, float amplificationValue)
        {
            if (SoundEngine.TryGetActiveSound(soundSlot, out ActiveSound? sound) && sound is not null)
            {
                sound.Volume *= amplificationValue;
            }
            return soundSlot;
        }
    }
}

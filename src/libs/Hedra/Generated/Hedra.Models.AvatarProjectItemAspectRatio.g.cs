
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AvatarProjectItemAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvatarProjectItemAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvatarProjectItemAspectRatio value)
        {
            return value switch
            {
                AvatarProjectItemAspectRatio.x1_1 => "1:1",
                AvatarProjectItemAspectRatio.x16_9 => "16:9",
                AvatarProjectItemAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvatarProjectItemAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => AvatarProjectItemAspectRatio.x1_1,
                "16:9" => AvatarProjectItemAspectRatio.x16_9,
                "9:16" => AvatarProjectItemAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
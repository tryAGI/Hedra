
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratedVideoInputsCharacterOrientation2
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedVideoInputsCharacterOrientation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedVideoInputsCharacterOrientation2 value)
        {
            return value switch
            {
                GeneratedVideoInputsCharacterOrientation2.Video => "video",
                GeneratedVideoInputsCharacterOrientation2.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedVideoInputsCharacterOrientation2? ToEnum(string value)
        {
            return value switch
            {
                "video" => GeneratedVideoInputsCharacterOrientation2.Video,
                "image" => GeneratedVideoInputsCharacterOrientation2.Image,
                _ => null,
            };
        }
    }
}
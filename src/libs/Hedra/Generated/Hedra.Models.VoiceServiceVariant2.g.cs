
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceServiceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceServiceVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceServiceVariant2 value)
        {
            return value switch
            {
                VoiceServiceVariant2.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceServiceVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => VoiceServiceVariant2.Cartesia,
                _ => null,
            };
        }
    }
}
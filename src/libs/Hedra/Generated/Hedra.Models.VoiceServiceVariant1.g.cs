
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceServiceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Eleven,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceServiceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceServiceVariant1 value)
        {
            return value switch
            {
                VoiceServiceVariant1.Eleven => "eleven",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceServiceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "eleven" => VoiceServiceVariant1.Eleven,
                _ => null,
            };
        }
    }
}
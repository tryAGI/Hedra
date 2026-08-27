
#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public enum GeneratedVideoInputsShotType2
    {
        /// <summary>
        ///
        /// </summary>
        Customize,
        /// <summary>
        ///
        /// </summary>
        Intelligent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedVideoInputsShotType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedVideoInputsShotType2 value)
        {
            return value switch
            {
                GeneratedVideoInputsShotType2.Customize => "customize",
                GeneratedVideoInputsShotType2.Intelligent => "intelligent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedVideoInputsShotType2? ToEnum(string value)
        {
            return value switch
            {
                "customize" => GeneratedVideoInputsShotType2.Customize,
                "intelligent" => GeneratedVideoInputsShotType2.Intelligent,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public enum GeneratedVideoInputsShotType
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
    public static class GeneratedVideoInputsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedVideoInputsShotType value)
        {
            return value switch
            {
                GeneratedVideoInputsShotType.Customize => "customize",
                GeneratedVideoInputsShotType.Intelligent => "intelligent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedVideoInputsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => GeneratedVideoInputsShotType.Customize,
                "intelligent" => GeneratedVideoInputsShotType.Intelligent,
                _ => null,
            };
        }
    }
}
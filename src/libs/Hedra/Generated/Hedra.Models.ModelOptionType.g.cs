
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelOptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOptionType value)
        {
            return value switch
            {
                ModelOptionType.Boolean => "boolean",
                ModelOptionType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOptionType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => ModelOptionType.Boolean,
                "enum" => ModelOptionType.Enum,
                _ => null,
            };
        }
    }
}
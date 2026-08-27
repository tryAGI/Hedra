
#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoPostProcessingSettingsFpsEngine2
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoPostProcessingSettingsFpsEngine2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPostProcessingSettingsFpsEngine2 value)
        {
            return value switch
            {
                VideoPostProcessingSettingsFpsEngine2.High => "high",
                VideoPostProcessingSettingsFpsEngine2.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPostProcessingSettingsFpsEngine2? ToEnum(string value)
        {
            return value switch
            {
                "high" => VideoPostProcessingSettingsFpsEngine2.High,
                "standard" => VideoPostProcessingSettingsFpsEngine2.Standard,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoPostProcessingSettingsFpsEngine
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
    public static class VideoPostProcessingSettingsFpsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPostProcessingSettingsFpsEngine value)
        {
            return value switch
            {
                VideoPostProcessingSettingsFpsEngine.High => "high",
                VideoPostProcessingSettingsFpsEngine.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPostProcessingSettingsFpsEngine? ToEnum(string value)
        {
            return value switch
            {
                "high" => VideoPostProcessingSettingsFpsEngine.High,
                "standard" => VideoPostProcessingSettingsFpsEngine.Standard,
                _ => null,
            };
        }
    }
}
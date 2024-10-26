
#nullable enable

namespace Hedra
{
    /// <summary>
    /// URL of audio uploaded using the /v1/audio endpoint<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum ApiGenerateTalkingAvatarRequestBodyAspectRatio
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
    public static class ApiGenerateTalkingAvatarRequestBodyAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiGenerateTalkingAvatarRequestBodyAspectRatio value)
        {
            return value switch
            {
                ApiGenerateTalkingAvatarRequestBodyAspectRatio.x1_1 => "1:1",
                ApiGenerateTalkingAvatarRequestBodyAspectRatio.x16_9 => "16:9",
                ApiGenerateTalkingAvatarRequestBodyAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiGenerateTalkingAvatarRequestBodyAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => ApiGenerateTalkingAvatarRequestBodyAspectRatio.x1_1,
                "16:9" => ApiGenerateTalkingAvatarRequestBodyAspectRatio.x16_9,
                "9:16" => ApiGenerateTalkingAvatarRequestBodyAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
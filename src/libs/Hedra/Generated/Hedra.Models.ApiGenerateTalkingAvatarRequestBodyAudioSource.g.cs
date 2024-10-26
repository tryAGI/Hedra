
#nullable enable

namespace Hedra
{
    /// <summary>
    /// `tts` for text to speech or `audio`<br/>
    /// Default Value: audio
    /// </summary>
    public enum ApiGenerateTalkingAvatarRequestBodyAudioSource
    {
        /// <summary>
        /// 
        /// </summary>
        Tts,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiGenerateTalkingAvatarRequestBodyAudioSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiGenerateTalkingAvatarRequestBodyAudioSource value)
        {
            return value switch
            {
                ApiGenerateTalkingAvatarRequestBodyAudioSource.Tts => "tts",
                ApiGenerateTalkingAvatarRequestBodyAudioSource.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiGenerateTalkingAvatarRequestBodyAudioSource? ToEnum(string value)
        {
            return value switch
            {
                "tts" => ApiGenerateTalkingAvatarRequestBodyAudioSource.Tts,
                "audio" => ApiGenerateTalkingAvatarRequestBodyAudioSource.Audio,
                _ => null,
            };
        }
    }
}
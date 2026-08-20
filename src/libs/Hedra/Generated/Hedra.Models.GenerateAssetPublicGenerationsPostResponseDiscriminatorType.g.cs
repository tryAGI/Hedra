
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateAssetPublicGenerationsPostResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        MotionControl,
        /// <summary>
        /// 
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToMusic,
        /// <summary>
        /// 
        /// </summary>
        TextToSound,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        VideoBackgroundRemoval,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        VideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssetPublicGenerationsPostResponseDiscriminatorType value)
        {
            return value switch
            {
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image => "image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage => "image_to_image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale => "image_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl => "motion_control",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToMusic => "text_to_music",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound => "text_to_sound",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video => "video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoBackgroundRemoval => "video_background_removal",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo => "video_to_video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale => "video_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_isolation" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation,
                "image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image,
                "image_to_image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage,
                "image_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale,
                "motion_control" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl,
                "speech_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech,
                "text_to_music" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToMusic,
                "text_to_sound" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound,
                "text_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech,
                "video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video,
                "video_background_removal" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoBackgroundRemoval,
                "video_to_video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo,
                "video_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale,
                "voice_clone" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone,
                _ => null,
            };
        }
    }
}
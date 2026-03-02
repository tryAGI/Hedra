
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateAssetPublicGenerationsPostRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToSound,
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
        VideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        VoiceClone,
        /// <summary>
        /// 
        /// </summary>
        AudioFromVideo,
        /// <summary>
        /// 
        /// </summary>
        VideoWithAudio,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        MotionControl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssetPublicGenerationsPostRequestDiscriminatorType value)
        {
            return value switch
            {
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video => "video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound => "text_to_sound",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image => "image",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageToImage => "image_to_image",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale => "image_upscale",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale => "video_upscale",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone => "voice_clone",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo => "audio_from_video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio => "video_with_audio",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo => "video_to_video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl => "motion_control",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video,
                "text_to_speech" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech,
                "text_to_sound" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound,
                "image" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image,
                "image_to_image" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageToImage,
                "image_upscale" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale,
                "video_upscale" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale,
                "audio_isolation" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation,
                "speech_to_speech" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech,
                "voice_clone" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone,
                "audio_from_video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo,
                "video_with_audio" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio,
                "video_to_video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo,
                "motion_control" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl,
                _ => null,
            };
        }
    }
}
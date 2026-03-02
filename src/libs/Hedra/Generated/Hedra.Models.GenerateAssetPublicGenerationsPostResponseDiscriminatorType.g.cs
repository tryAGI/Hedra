
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
    public static class GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssetPublicGenerationsPostResponseDiscriminatorType value)
        {
            return value switch
            {
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video => "video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound => "text_to_sound",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image => "image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage => "image_to_image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale => "image_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale => "video_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone => "voice_clone",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo => "audio_from_video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio => "video_with_audio",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo => "video_to_video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl => "motion_control",
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
                "video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video,
                "text_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech,
                "text_to_sound" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound,
                "image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image,
                "image_to_image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage,
                "image_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale,
                "video_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale,
                "audio_isolation" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation,
                "speech_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech,
                "voice_clone" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone,
                "audio_from_video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo,
                "video_with_audio" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio,
                "video_to_video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo,
                "motion_control" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl,
                _ => null,
            };
        }
    }
}
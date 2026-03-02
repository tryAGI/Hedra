
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Generation type enum<br/>
    /// NOTE: this enum is used to determine the type of generation and is used to determine<br/>
    /// the type of asset that will be generated.
    /// </summary>
    public enum GenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
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
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        VoiceClone,
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        VideoStitching,
        /// <summary>
        /// 
        /// </summary>
        VideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        ImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        AudioFromVideo,
        /// <summary>
        /// 
        /// </summary>
        TextToSound,
        /// <summary>
        /// 
        /// </summary>
        AssetsToImageTextPrompt,
        /// <summary>
        /// 
        /// </summary>
        AssetsToAudioTextPrompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationType value)
        {
            return value switch
            {
                GenerationType.Image => "image",
                GenerationType.Video => "video",
                GenerationType.TextToSpeech => "text_to_speech",
                GenerationType.SpeechToSpeech => "speech_to_speech",
                GenerationType.VoiceClone => "voice_clone",
                GenerationType.AudioIsolation => "audio_isolation",
                GenerationType.VideoStitching => "video_stitching",
                GenerationType.VideoUpscale => "video_upscale",
                GenerationType.VideoToVideo => "video_to_video",
                GenerationType.ImageUpscale => "image_upscale",
                GenerationType.AgentResponse => "agent_response",
                GenerationType.AudioFromVideo => "audio_from_video",
                GenerationType.TextToSound => "text_to_sound",
                GenerationType.AssetsToImageTextPrompt => "assets_to_image_text_prompt",
                GenerationType.AssetsToAudioTextPrompt => "assets_to_audio_text_prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationType? ToEnum(string value)
        {
            return value switch
            {
                "image" => GenerationType.Image,
                "video" => GenerationType.Video,
                "text_to_speech" => GenerationType.TextToSpeech,
                "speech_to_speech" => GenerationType.SpeechToSpeech,
                "voice_clone" => GenerationType.VoiceClone,
                "audio_isolation" => GenerationType.AudioIsolation,
                "video_stitching" => GenerationType.VideoStitching,
                "video_upscale" => GenerationType.VideoUpscale,
                "video_to_video" => GenerationType.VideoToVideo,
                "image_upscale" => GenerationType.ImageUpscale,
                "agent_response" => GenerationType.AgentResponse,
                "audio_from_video" => GenerationType.AudioFromVideo,
                "text_to_sound" => GenerationType.TextToSound,
                "assets_to_image_text_prompt" => GenerationType.AssetsToImageTextPrompt,
                "assets_to_audio_text_prompt" => GenerationType.AssetsToAudioTextPrompt,
                _ => null,
            };
        }
    }
}
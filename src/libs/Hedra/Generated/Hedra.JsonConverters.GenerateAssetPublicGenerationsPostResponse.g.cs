#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public class GenerateAssetPublicGenerationsPostResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.GenerateAssetPublicGenerationsPostResponse>
    {
        /// <inheritdoc />
        public override global::Hedra.GenerateAssetPublicGenerationsPostResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Hedra.GenerateVideoResponse? video = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoResponse)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateTextToSpeechResponse? textToSpeech = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateTextToSpeechResponse)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateTextToSoundResponse? textToSound = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateTextToSoundResponse)}");
                textToSound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateImageResponse? image = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateImageResponse)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateImageUpscaleResponse? imageUpscale = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateImageUpscaleResponse)}");
                imageUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoUpscaleResponse? videoUpscale = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoUpscaleResponse)}");
                videoUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateIsolatedAudioResponse? audioIsolation = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateIsolatedAudioResponse)}");
                audioIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateSpeechToSpeechResponse? speechToSpeech = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateSpeechToSpeechResponse)}");
                speechToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVoiceCloneResponse? voiceClone = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVoiceCloneResponse)}");
                voiceClone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateAudioFromVideoResponse? audioFromVideo = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateAudioFromVideoResponse)}");
                audioFromVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoWithAudioResponse? videoWithAudio = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoWithAudioResponse)}");
                videoWithAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoToVideoResponse? videoToVideo = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoToVideoResponse)}");
                videoToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateMotionControlResponse? motionControl = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateMotionControlResponse)}");
                motionControl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Hedra.GenerateAssetPublicGenerationsPostResponse(
                discriminator?.Type,
                video,
                textToSpeech,
                textToSound,
                image,
                imageUpscale,
                videoUpscale,
                audioIsolation,
                speechToSpeech,
                voiceClone,
                audioFromVideo,
                videoWithAudio,
                videoToVideo,
                motionControl
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GenerateAssetPublicGenerationsPostResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech, typeInfo);
            }
            else if (value.IsTextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSound, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUpscale, typeInfo);
            }
            else if (value.IsVideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUpscale, typeInfo);
            }
            else if (value.IsAudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioIsolation, typeInfo);
            }
            else if (value.IsSpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechToSpeech, typeInfo);
            }
            else if (value.IsVoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceClone, typeInfo);
            }
            else if (value.IsAudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioFromVideo, typeInfo);
            }
            else if (value.IsVideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoWithAudio, typeInfo);
            }
            else if (value.IsVideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoToVideo, typeInfo);
            }
            else if (value.IsMotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MotionControl, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public class GenerateAssetPublicGenerationsPostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.GenerateAssetPublicGenerationsPostRequest>
    {
        /// <inheritdoc />
        public override global::Hedra.GenerateAssetPublicGenerationsPostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Hedra.GenerateVideoRequestInput? video = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoRequestInput)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateTextToSpeechRequest? textToSpeech = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateTextToSpeechRequest)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateTextToSoundRequest? textToSound = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateTextToSoundRequest)}");
                textToSound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateImageRequest? image = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateImageRequest)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateImageUpscaleRequest? imageUpscale = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateImageUpscaleRequest)}");
                imageUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoUpscaleRequest? videoUpscale = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoUpscaleRequest)}");
                videoUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateIsolatedAudioRequest? audioIsolation = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateIsolatedAudioRequest)}");
                audioIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateSpeechToSpeechRequest? speechToSpeech = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateSpeechToSpeechRequest)}");
                speechToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVoiceCloneRequest? voiceClone = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVoiceCloneRequest)}");
                voiceClone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateAudioFromVideoRequest? audioFromVideo = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateAudioFromVideoRequest)}");
                audioFromVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoWithAudioRequest? videoWithAudio = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoWithAudioRequest)}");
                videoWithAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateVideoToVideoRequest? videoToVideo = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateVideoToVideoRequest)}");
                videoToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GenerateMotionControlRequestInput? motionControl = default;
            if (discriminator?.Type == global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GenerateMotionControlRequestInput)}");
                motionControl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Hedra.GenerateAssetPublicGenerationsPostRequest(
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GenerateAssetPublicGenerationsPostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech, typeInfo);
            }
            else if (value.IsTextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSound, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUpscale, typeInfo);
            }
            else if (value.IsVideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUpscale, typeInfo);
            }
            else if (value.IsAudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioIsolation, typeInfo);
            }
            else if (value.IsSpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechToSpeech, typeInfo);
            }
            else if (value.IsVoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceClone, typeInfo);
            }
            else if (value.IsAudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioFromVideo, typeInfo);
            }
            else if (value.IsVideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoWithAudio, typeInfo);
            }
            else if (value.IsVideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoToVideo, typeInfo);
            }
            else if (value.IsMotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MotionControl, typeInfo);
            }
        }
    }
}
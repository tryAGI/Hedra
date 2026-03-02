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

            var
            readerCopy = reader;
            global::Hedra.GenerateVideoRequestInput? videoInput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestInput).Name}");
                videoInput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateTextToSpeechRequest? textToSpeech = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateTextToSoundRequest? textToSound = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                textToSound = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateImageRequest? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateImageUpscaleRequest? imageUpscale = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                imageUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoUpscaleRequest? videoUpscale = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                videoUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateIsolatedAudioRequest? isolatedAudio = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                isolatedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateSpeechToSpeechRequest? speechTo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                speechTo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVoiceCloneRequest? voiceClone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                voiceClone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateAudioFromVideoRequest? audioFromVideo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                audioFromVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoWithAudioRequest? videoWithAudio = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                videoWithAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoToVideoRequest? videoTo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                videoTo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateMotionControlRequestInput? motionControlInput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestInput).Name}");
                motionControlInput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Hedra.GenerateAssetPublicGenerationsPostRequest(
                videoInput,
                textToSpeech,
                textToSound,
                image,
                imageUpscale,
                videoUpscale,
                isolatedAudio,
                speechTo,
                voiceClone,
                audioFromVideo,
                videoWithAudio,
                videoTo,
                motionControlInput
                );

            if (videoInput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textToSpeech != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textToSound != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (imageUpscale != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (videoUpscale != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (isolatedAudio != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (speechTo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (voiceClone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioFromVideo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (videoWithAudio != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (videoTo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (motionControlInput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GenerateAssetPublicGenerationsPostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideoInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoInput, typeInfo);
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
            else if (value.IsIsolatedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IsolatedAudio, typeInfo);
            }
            else if (value.IsSpeechTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechTo, typeInfo);
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
            else if (value.IsVideoTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoTo, typeInfo);
            }
            else if (value.IsMotionControlInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MotionControlInput, typeInfo);
            }
        }
    }
}
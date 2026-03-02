#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public class InputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.Input>
    {
        /// <inheritdoc />
        public override global::Hedra.Input Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Hedra.GenerateVideoRequestOutput? generateVideoRequestOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestOutput).Name}");
                generateVideoRequestOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateTextToSpeechRequest? generateTextToSpeechRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                generateTextToSpeechRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateTextToSoundRequest? generateTextToSoundRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                generateTextToSoundRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateImageRequest? generateImageRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                generateImageRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateImageUpscaleRequest? generateImageUpscaleRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                generateImageUpscaleRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoUpscaleRequest? generateVideoUpscaleRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                generateVideoUpscaleRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateIsolatedAudioRequest? generateIsolatedAudioRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                generateIsolatedAudioRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateSpeechToSpeechRequest? generateSpeechToRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                generateSpeechToRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVoiceCloneRequest? generateVoiceCloneRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                generateVoiceCloneRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateAudioFromVideoRequest? generateAudioFromVideoRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                generateAudioFromVideoRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoWithAudioRequest? generateVideoWithAudioRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                generateVideoWithAudioRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateVideoToVideoRequest? generateVideoToRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                generateVideoToRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Hedra.GenerateMotionControlRequestOutput? generateMotionControlRequestOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestOutput).Name}");
                generateMotionControlRequestOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Hedra.Input(
                generateVideoRequestOutput,
                generateTextToSpeechRequest,
                generateTextToSoundRequest,
                generateImageRequest,
                generateImageUpscaleRequest,
                generateVideoUpscaleRequest,
                generateIsolatedAudioRequest,
                generateSpeechToRequest,
                generateVoiceCloneRequest,
                generateAudioFromVideoRequest,
                generateVideoWithAudioRequest,
                generateVideoToRequest,
                generateMotionControlRequestOutput
                );

            if (generateVideoRequestOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateTextToSpeechRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateTextToSoundRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateImageRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateImageUpscaleRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateVideoUpscaleRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateIsolatedAudioRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateSpeechToRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateVoiceCloneRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateAudioFromVideoRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateVideoWithAudioRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateVideoToRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generateMotionControlRequestOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.Input value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerateVideoRequestOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoRequestOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoRequestOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateVideoRequestOutput, typeInfo);
            }
            else if (value.IsGenerateTextToSpeechRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateTextToSpeechRequest, typeInfo);
            }
            else if (value.IsGenerateTextToSoundRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateTextToSoundRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateTextToSoundRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateTextToSoundRequest, typeInfo);
            }
            else if (value.IsGenerateImageRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateImageRequest, typeInfo);
            }
            else if (value.IsGenerateImageUpscaleRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateImageUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateImageUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateImageUpscaleRequest, typeInfo);
            }
            else if (value.IsGenerateVideoUpscaleRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateVideoUpscaleRequest, typeInfo);
            }
            else if (value.IsGenerateIsolatedAudioRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateIsolatedAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateIsolatedAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateIsolatedAudioRequest, typeInfo);
            }
            else if (value.IsGenerateSpeechToRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateSpeechToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateSpeechToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateSpeechToRequest, typeInfo);
            }
            else if (value.IsGenerateVoiceCloneRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVoiceCloneRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVoiceCloneRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateVoiceCloneRequest, typeInfo);
            }
            else if (value.IsGenerateAudioFromVideoRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateAudioFromVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateAudioFromVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateAudioFromVideoRequest, typeInfo);
            }
            else if (value.IsGenerateVideoWithAudioRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoWithAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoWithAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateVideoWithAudioRequest, typeInfo);
            }
            else if (value.IsGenerateVideoToRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateVideoToVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateVideoToVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateVideoToRequest, typeInfo);
            }
            else if (value.IsGenerateMotionControlRequestOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GenerateMotionControlRequestOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GenerateMotionControlRequestOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GenerateMotionControlRequestOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerateMotionControlRequestOutput, typeInfo);
            }
        }
    }
}
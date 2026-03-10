#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public class Asset1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.Asset1>
    {
        /// <inheritdoc />
        public override global::Hedra.Asset1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.AssetAsset1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.AssetAsset1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.AssetAsset1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Hedra.UploadedImage? uploadedImage = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.UploadedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.UploadedImage)}");
                uploadedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.UploadedAudio? uploadedAudio = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.UploadedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.UploadedAudio)}");
                uploadedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.UploadedVideo? uploadedVideo = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.UploadedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.UploadedVideo)}");
                uploadedVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GeneratedAudio? generatedAudio = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.GeneratedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GeneratedAudio)}");
                generatedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GeneratedImage? generatedImage = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.GeneratedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GeneratedImage)}");
                generatedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.GeneratedVideo? generatedVideo = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.GeneratedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.GeneratedVideo)}");
                generatedVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Hedra.Voice? voice = default;
            if (discriminator?.Type == global::Hedra.AssetAsset1DiscriminatorType.Voice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.Voice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.Voice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Hedra.Voice)}");
                voice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Hedra.Asset1(
                discriminator?.Type,
                uploadedImage,

                uploadedAudio,

                uploadedVideo,

                generatedAudio,

                generatedImage,

                generatedVideo,

                voice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.Asset1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUploadedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.UploadedImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedImage, typeInfo);
            }
            else if (value.IsUploadedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.UploadedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedAudio, typeInfo);
            }
            else if (value.IsUploadedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.UploadedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.UploadedVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.UploadedVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedVideo, typeInfo);
            }
            else if (value.IsGeneratedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GeneratedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedAudio, typeInfo);
            }
            else if (value.IsGeneratedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GeneratedImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedImage, typeInfo);
            }
            else if (value.IsGeneratedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.GeneratedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.GeneratedVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.GeneratedVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedVideo, typeInfo);
            }
            else if (value.IsVoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hedra.Voice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hedra.Voice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hedra.Voice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voice, typeInfo);
            }
        }
    }
}
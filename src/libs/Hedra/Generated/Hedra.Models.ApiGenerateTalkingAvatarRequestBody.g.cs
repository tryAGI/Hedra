
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiGenerateTalkingAvatarRequestBody
    {
        /// <summary>
        /// text to convert to audio. Ignored if audio_source is not tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Voice ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Hedra.AnyOf<string, object>? VoiceId { get; set; }

        /// <summary>
        /// URL of audio uploaded using the /v1/audio endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceUrl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Hedra.AnyOf<string, object>? VoiceUrl { get; set; }

        /// <summary>
        /// URL of image uploaded via /v1/portrait
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Hedra.AnyOf<string, object>? AvatarImage { get; set; }

        /// <summary>
        /// URL of audio uploaded using the /v1/audio endpoint<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAspectRatioJsonConverter))]
        public global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// `tts` for text to speech or `audio`<br/>
        /// Default Value: audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAudioSourceJsonConverter))]
        public global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? AudioSource { get; set; }

        /// <summary>
        /// Image metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImageInput")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Hedra.AnyOf<global::Hedra.AvatarImageInput2, object>? AvatarImageInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Hedra.ApiGenerateTalkingAvatarRequestBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Hedra.ApiGenerateTalkingAvatarRequestBody),
                jsonSerializerContext) as global::Hedra.ApiGenerateTalkingAvatarRequestBody;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Hedra.ApiGenerateTalkingAvatarRequestBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Hedra.ApiGenerateTalkingAvatarRequestBody>(
                json,
                jsonSerializerOptions);
        }

    }
}
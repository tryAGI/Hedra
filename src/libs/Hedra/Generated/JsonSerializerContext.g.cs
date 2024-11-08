
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAspectRatioJsonConverter),
            typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAspectRatioNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAudioSourceJsonConverter),
            typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAudioSourceNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.AvatarProjectItemAspectRatioJsonConverter),
            typeof(global::Hedra.JsonConverters.AvatarProjectItemAspectRatioNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.VoiceServiceVariant1JsonConverter),
            typeof(global::Hedra.JsonConverters.VoiceServiceVariant1NullableJsonConverter),
            typeof(global::Hedra.JsonConverters.VoiceServiceVariant2JsonConverter),
            typeof(global::Hedra.JsonConverters.VoiceServiceVariant2NullableJsonConverter),
            typeof(global::Hedra.JsonConverters.AnyOfJsonConverterFactory2),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
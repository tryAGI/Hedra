
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
            typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.AssetTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GeneratedVideoInputsCharacterOrientation2JsonConverter),
            typeof(global::Hedra.JsonConverters.GeneratedVideoInputsCharacterOrientation2NullableJsonConverter),
            typeof(global::Hedra.JsonConverters.AssetAsset1DiscriminatorTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.AssetAsset1DiscriminatorTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationStatusJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationStatusNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.ErrorCodeJsonConverter),
            typeof(global::Hedra.JsonConverters.ErrorCodeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateImageRequestTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateImageRequestTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateImageResponseTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateImageResponseTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.SupportedLanguageJsonConverter),
            typeof(global::Hedra.JsonConverters.SupportedLanguageNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationInputDiscriminatorTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationInputDiscriminatorTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerationTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeNullableJsonConverter),
            typeof(global::Hedra.JsonConverters.Asset1JsonConverter),
            typeof(global::Hedra.JsonConverters.InputJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestJsonConverter),
            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseJsonConverter),
            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::Hedra.AssetType?, global::Hedra.GenerationType?, object>),
            typeof(global::Hedra.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
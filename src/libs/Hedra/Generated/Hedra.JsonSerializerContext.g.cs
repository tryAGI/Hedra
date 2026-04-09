
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
            typeof(global::Hedra.JsonConverters.AssetAsset1DiscriminatorTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.AssetAsset1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.AssetTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.ErrorCodeJsonConverter),

            typeof(global::Hedra.JsonConverters.ErrorCodeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateImageRequestTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateImageRequestTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateImageResponseTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateImageResponseTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GeneratedVideoInputsCharacterOrientation2JsonConverter),

            typeof(global::Hedra.JsonConverters.GeneratedVideoInputsCharacterOrientation2NullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationInputDiscriminatorTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationStatusJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationStatusNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerationTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.SupportedLanguageJsonConverter),

            typeof(global::Hedra.JsonConverters.SupportedLanguageNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Hedra.JsonConverters.Asset1JsonConverter),

            typeof(global::Hedra.JsonConverters.InputJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostRequestJsonConverter),

            typeof(global::Hedra.JsonConverters.GenerateAssetPublicGenerationsPostResponseJsonConverter),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::Hedra.AssetType?, global::Hedra.GenerationType?, object>),

            typeof(global::Hedra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AIModelPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Hedra.Dimension>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Hedra.Dimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Dimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.InputMode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.InputMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Asset1), TypeInfoPropertyName = "Asset12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.UploadedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.UploadedAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.UploadedVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AssetAsset1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AssetAsset1DiscriminatorType), TypeInfoPropertyName = "AssetAsset1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.BatchImageResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationStatus), TypeInfoPropertyName = "GenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.BatchVideoResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.BodyUploadAssetPublicAssetsIdUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.CreateAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.CreateAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.CreditBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAudioFromVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAudioFromVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageRequestType), TypeInfoPropertyName = "GenerateImageRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageResponseType), TypeInfoPropertyName = "GenerateImageResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.BatchImageResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateIsolatedAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateIsolatedAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateMotionControlRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedVideoInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateMotionControlRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateMotionControlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateSpeechToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateSpeechToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateTextToSoundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateTextToSoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateTextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateTextToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>), TypeInfoPropertyName = "AnyOfGuidIListGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.BatchVideoResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.KlingEditElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.KlingEditElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoWithAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVideoWithAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateVoiceCloneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedAudioInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedImageInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>), TypeInfoPropertyName = "AnyOfIListDoubleIListIListDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GeneratedVideoInputsCharacterOrientation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.VideoShot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.VideoShot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.Input), TypeInfoPropertyName = "Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationInputDiscriminatorType), TypeInfoPropertyName = "GenerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerationType), TypeInfoPropertyName = "GenerationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.InputSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.InputSlot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.PagedResponseGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.Generation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.PagingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.VoiceLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.VoiceLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostRequest), TypeInfoPropertyName = "GenerateAssetPublicGenerationsPostRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType), TypeInfoPropertyName = "GenerateAssetPublicGenerationsPostRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<global::Hedra.AssetType?, global::Hedra.GenerationType?, object>), TypeInfoPropertyName = "AnyOfAssetTypeGenerationTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.AIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hedra.Asset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostResponse), TypeInfoPropertyName = "GenerateAssetPublicGenerationsPostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType), TypeInfoPropertyName = "GenerateAssetPublicGenerationsPostResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.InputMode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.BatchImageResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.BatchVideoResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.KlingEditElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hedra.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.VideoShot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.InputSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.Generation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.VoiceLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.AIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hedra.Asset>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}

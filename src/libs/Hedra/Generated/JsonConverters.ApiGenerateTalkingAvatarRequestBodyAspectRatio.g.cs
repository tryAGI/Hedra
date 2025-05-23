#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiGenerateTalkingAvatarRequestBodyAspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio>
    {
        /// <inheritdoc />
        public override global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio Read(
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
                        return global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatioExtensions.ToValueString(value));
        }
    }
}

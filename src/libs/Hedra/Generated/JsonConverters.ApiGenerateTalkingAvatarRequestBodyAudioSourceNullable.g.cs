#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiGenerateTalkingAvatarRequestBodyAudioSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource?>
    {
        /// <inheritdoc />
        public override global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? Read(
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
                        return global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}

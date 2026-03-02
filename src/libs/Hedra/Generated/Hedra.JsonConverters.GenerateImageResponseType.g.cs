#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateImageResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.GenerateImageResponseType>
    {
        /// <inheritdoc />
        public override global::Hedra.GenerateImageResponseType Read(
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
                        return global::Hedra.GenerateImageResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.GenerateImageResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hedra.GenerateImageResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GenerateImageResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Hedra.GenerateImageResponseTypeExtensions.ToValueString(value));
        }
    }
}

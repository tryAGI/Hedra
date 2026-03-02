#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class GeneratedVideoInputsCharacterOrientation2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.GeneratedVideoInputsCharacterOrientation2>
    {
        /// <inheritdoc />
        public override global::Hedra.GeneratedVideoInputsCharacterOrientation2 Read(
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
                        return global::Hedra.GeneratedVideoInputsCharacterOrientation2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.GeneratedVideoInputsCharacterOrientation2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hedra.GeneratedVideoInputsCharacterOrientation2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.GeneratedVideoInputsCharacterOrientation2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Hedra.GeneratedVideoInputsCharacterOrientation2Extensions.ToValueString(value));
        }
    }
}

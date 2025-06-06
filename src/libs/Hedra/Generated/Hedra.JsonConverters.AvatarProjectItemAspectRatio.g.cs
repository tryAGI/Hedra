#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class AvatarProjectItemAspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hedra.AvatarProjectItemAspectRatio>
    {
        /// <inheritdoc />
        public override global::Hedra.AvatarProjectItemAspectRatio Read(
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
                        return global::Hedra.AvatarProjectItemAspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hedra.AvatarProjectItemAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hedra.AvatarProjectItemAspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hedra.AvatarProjectItemAspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Hedra.AvatarProjectItemAspectRatioExtensions.ToValueString(value));
        }
    }
}

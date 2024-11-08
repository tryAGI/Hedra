#nullable enable

namespace Hedra.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnyOfJsonConverterFactory2 : global::System.Text.Json.Serialization.JsonConverterFactory
    {
        /// <inheritdoc />
        public override bool CanConvert(global::System.Type? typeToConvert)
        {
            return typeToConvert is { IsGenericType: true } && typeToConvert.GetGenericTypeDefinition() == typeof(global::Hedra.AnyOf<,>);
        }

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof(AnyOfJsonConverter<,>).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }
    }
}

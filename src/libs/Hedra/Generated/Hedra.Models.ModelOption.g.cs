
#nullable enable

namespace Hedra
{
    /// <summary>
    /// One published option: a closed enum or a boolean.<br/>
    /// Published verbatim to `/models`; the value vocabulary is deliberately<br/>
    /// closed (no numbers, no free text) so the frontend can render every option<br/>
    /// with two control shapes and submit validation stays a set-membership<br/>
    /// check.
    /// </summary>
    public sealed partial class ModelOption
    {
        /// <summary>
        /// snake_case wire name; key in `options`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ModelOptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.ModelOptionType Type { get; set; }

        /// <summary>
        /// Enum members, in display order. Enum only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Value applied when the request omits the option; always the provider's own default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<string, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.AnyOf<string, bool?> Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOption" /> class.
        /// </summary>
        /// <param name="name">
        /// snake_case wire name; key in `options`.
        /// </param>
        /// <param name="type"></param>
        /// <param name="default">
        /// Value applied when the request omits the option; always the provider's own default.
        /// </param>
        /// <param name="values">
        /// Enum members, in display order. Enum only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelOption(
            string name,
            global::Hedra.ModelOptionType type,
            global::Hedra.AnyOf<string, bool?> @default,
            global::System.Collections.Generic.IList<string>? values)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Values = values;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOption" /> class.
        /// </summary>
        public ModelOption()
        {
        }

    }
}
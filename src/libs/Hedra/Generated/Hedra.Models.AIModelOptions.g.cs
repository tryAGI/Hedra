
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Scalar options the model accepts per generation (closed enums and booleans), price-neutral unless a value declares a `price_multiplier` — the quote endpoint reflects any declared multiplier, so clients never do pricing math. Submit validates the request's `options` payload against this declaration; every default equals the provider's own default, so omission and explicit-default are equivalent. Null when the model publishes none.
    /// </summary>
    public sealed partial class AIModelOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Credits the account had when the generation was rejected. Set only for `MISSING_CREDITS`. Paired with `credits_needed` so clients can render the shortfall without parsing `message`.
    /// </summary>
    public sealed partial class GenerationErrorCreditsAvailable
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Credits the generation required. Set only for `INSUFFICIENT_BALANCE`, and only when the failing check knew the cost.
    /// </summary>
    public sealed partial class GenerationErrorCreditsNeeded
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
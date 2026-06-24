
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Absolute UTC timestamp when the generation is estimated to complete. Clients should anchor a countdown to this rather than decaying eta_sec, since it self-corrects as the backend refines the estimate.
    /// </summary>
    public sealed partial class GenerationEstimatedCompletionAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
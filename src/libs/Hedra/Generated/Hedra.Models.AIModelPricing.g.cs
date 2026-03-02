
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Extensible pricing information with dimension modifiers for resolution, audio, etc.
    /// </summary>
    public sealed partial class AIModelPricing
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
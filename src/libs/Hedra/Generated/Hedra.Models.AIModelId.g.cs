
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Environment-specific UUID of the model, or null for a code-backed model with no `ai_models` row (identified by `slug`). Being removed in favor of `slug` (model-registry plan step 7); prefer `slug`.
    /// </summary>
    public sealed partial class AIModelId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
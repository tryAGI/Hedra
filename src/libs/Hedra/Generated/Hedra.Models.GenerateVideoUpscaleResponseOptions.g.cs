
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Per-generation option values, keyed by the option names the model publishes on `/models`. Unknown names and out-of-menu values are rejected.
    /// </summary>
    public sealed partial class GenerateVideoUpscaleResponseOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
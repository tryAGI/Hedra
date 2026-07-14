
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Segregated API wallet balance in integer micro-dollars (1e-6 USD). Only present while the API wallet is enabled and funded; spent exclusively by programmatic API usage.
    /// </summary>
    public sealed partial class WorkspaceCreditUsageApiUsdMicros
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
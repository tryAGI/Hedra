
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Lifetime micro-dollars spent from the API wallet (carried across billing periods — the wallet has none). Only present while the API wallet is enabled and funded.
    /// </summary>
    public sealed partial class WorkspaceCreditUsageApiConsumedUsdMicros
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
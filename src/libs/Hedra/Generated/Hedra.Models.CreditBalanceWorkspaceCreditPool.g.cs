
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Per-workspace credit pool usage (used/allocated/available) keyed by workspace_id. Only included if user is in a workspace.
    /// </summary>
    public sealed partial class CreditBalanceWorkspaceCreditPool
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
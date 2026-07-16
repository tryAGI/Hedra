
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional list of pre-reserved asset IDs for batch operations. Length must match batch_size, parallel to generation_ids. Mutually exclusive with reserved_asset_id.
    /// </summary>
    public sealed partial class GenerateVoiceCloneResponseReservedAssetIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
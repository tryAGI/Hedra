
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional pre-reserved asset ID, used as the produced media+asset resource_id so the client knows the upload's identity before it completes.
    /// </summary>
    public sealed partial class CreateAssetRequestReservedAssetId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
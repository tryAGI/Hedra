
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional pre-reserved asset ID. Used as the produced media+asset resource_id so the client knows the asset's identity at request time. For batch operations (batch_size &gt; 1), use reserved_asset_ids instead. Named distinctly from the response's `asset_id` (the produced asset) so the two don't collide across the request/response inheritance chain — mirrors generation_id (request) vs id (response).
    /// </summary>
    public sealed partial class GenerateSpeechToSpeechResponseReservedAssetId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
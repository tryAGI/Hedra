
#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAssetRequest
    {
        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.AssetType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional pre-reserved asset ID, used as the produced media+asset resource_id so the client knows the upload's identity before it completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_asset_id")]
        public global::System.Guid? ReservedAssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="reservedAssetId">
        /// Optional pre-reserved asset ID, used as the produced media+asset resource_id so the client knows the upload's identity before it completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetRequest(
            string name,
            global::Hedra.AssetType type,
            string? workspaceId,
            global::System.Guid? reservedAssetId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.WorkspaceId = workspaceId;
            this.ReservedAssetId = reservedAssetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        public CreateAssetRequest()
        {
        }

    }
}
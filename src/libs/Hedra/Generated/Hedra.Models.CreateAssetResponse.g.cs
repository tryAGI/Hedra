
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetResponse
    {
        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.AssetType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// The id of the newly created asset. Should be used for upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Presigned S3 URL for uploading the asset file using HTTP PUT. Only present when the asset type is VIDEO.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="id">
        /// The id of the newly created asset. Should be used for upload.
        /// </param>
        /// <param name="uploadUrl">
        /// Presigned S3 URL for uploading the asset file using HTTP PUT. Only present when the asset type is VIDEO.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetResponse(
            string name,
            global::Hedra.AssetType type,
            global::System.Guid id,
            string? workspaceId,
            string? uploadUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.UploadUrl = uploadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetResponse" /> class.
        /// </summary>
        public CreateAssetResponse()
        {
        }
    }
}
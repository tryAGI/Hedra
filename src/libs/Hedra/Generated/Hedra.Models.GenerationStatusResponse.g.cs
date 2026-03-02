
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationStatusResponse
    {
        /// <summary>
        /// ID of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// ID of the generated asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid AssetId { get; set; } = default!;

        /// <summary>
        /// Type of generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.AssetType Type { get; set; } = default!;

        /// <summary>
        /// Status of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.GenerationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.GenerationStatus Status { get; set; } = default!;

        /// <summary>
        /// Current progress to completion. Between 0-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Hedra.GenerationError2? Error { get; set; }

        /// <summary>
        /// Error message. Value is not present unless the status of the generation is 'error'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// URL of the generated asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL to download the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// URL to stream the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_url")]
        public string? StreamingUrl { get; set; }

        /// <summary>
        /// ID of the workspace this generation belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the generation.
        /// </param>
        /// <param name="assetId">
        /// ID of the generated asset.
        /// </param>
        /// <param name="type">
        /// Type of generation.
        /// </param>
        /// <param name="status">
        /// Status of the generation.
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1
        /// </param>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="error">
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </param>
        /// <param name="errorMessage">
        /// Error message. Value is not present unless the status of the generation is 'error'
        /// </param>
        /// <param name="url">
        /// URL of the generated asset.
        /// </param>
        /// <param name="downloadUrl">
        /// URL to download the asset.
        /// </param>
        /// <param name="streamingUrl">
        /// URL to stream the asset.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this generation belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationStatusResponse(
            global::System.Guid id,
            global::System.Guid assetId,
            global::Hedra.AssetType type,
            global::Hedra.GenerationStatus status,
            double progress,
            string createdAt,
            global::Hedra.GenerationError2? error,
            string? errorMessage,
            string? url,
            string? downloadUrl,
            string? streamingUrl,
            string? workspaceId)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.Type = type;
            this.Status = status;
            this.Progress = progress;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Error = error;
            this.ErrorMessage = errorMessage;
            this.Url = url;
            this.DownloadUrl = downloadUrl;
            this.StreamingUrl = streamingUrl;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        public GenerationStatusResponse()
        {
        }
    }
}
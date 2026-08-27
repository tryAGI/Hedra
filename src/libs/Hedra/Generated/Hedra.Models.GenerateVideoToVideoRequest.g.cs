
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Video-to-video edit request for Kling O1 Edit model.<br/>
    /// Transforms videos using natural language while preserving motion.
    /// </summary>
    public sealed partial class GenerateVideoToVideoRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional agent thread ID to associate this generation with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_thread_id")]
        public global::System.Guid? AgentThreadId { get; set; }

        /// <summary>
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GenerationIds { get; set; }

        /// <summary>
        /// Optional pre-reserved asset ID. Used as the produced media+asset resource_id so the client knows the asset's identity at request time. For batch operations (batch_size &gt; 1), use reserved_asset_ids instead. Named distinctly from the response's `asset_id` (the produced asset) so the two don't collide across the request/response inheritance chain — mirrors generation_id (request) vs id (response).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_asset_id")]
        public global::System.Guid? ReservedAssetId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved asset IDs for batch operations. Length must match batch_size, parallel to generation_ids. Mutually exclusive with reserved_asset_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_asset_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReservedAssetIds { get; set; }

        /// <summary>
        /// Default Value: video_to_video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Deprecated. Use `model_slug` to select the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// The slug of the model to use. Alternative to the deprecated model id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// The id of the video asset to transform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// Natural language transformation instructions. Use @Element1, @Image1 syntax to reference elements and images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional ids of reference image assets for style transfer. Reference as @Image1, @Image2, etc. in prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageAssetIds { get; set; }

        /// <summary>
        /// Optional elements for character tracking. Reference as @Element1, @Element2, etc. in prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::Hedra.KlingEditElement>? Elements { get; set; }

        /// <summary>
        /// Whether to preserve the original audio from the input video. Automatically disabled when generate_audio is enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_audio")]
        public bool? KeepAudio { get; set; }

        /// <summary>
        /// Optional FPS and HDR processing applied before delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_processing")]
        public global::Hedra.VideoPostProcessingSettings? PostProcessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoToVideoRequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// The id of the video asset to transform.
        /// </param>
        /// <param name="prompt">
        /// Natural language transformation instructions. Use @Element1, @Image1 syntax to reference elements and images.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="agentThreadId">
        /// Optional agent thread ID to associate this generation with.
        /// </param>
        /// <param name="generationId">
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </param>
        /// <param name="generationIds">
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </param>
        /// <param name="reservedAssetId">
        /// Optional pre-reserved asset ID. Used as the produced media+asset resource_id so the client knows the asset's identity at request time. For batch operations (batch_size &gt; 1), use reserved_asset_ids instead. Named distinctly from the response's `asset_id` (the produced asset) so the two don't collide across the request/response inheritance chain — mirrors generation_id (request) vs id (response).
        /// </param>
        /// <param name="reservedAssetIds">
        /// Optional list of pre-reserved asset IDs for batch operations. Length must match batch_size, parallel to generation_ids. Mutually exclusive with reserved_asset_id.
        /// </param>
        /// <param name="type">
        /// Default Value: video_to_video
        /// </param>
        /// <param name="modelSlug">
        /// The slug of the model to use. Alternative to the deprecated model id.
        /// </param>
        /// <param name="referenceImageAssetIds">
        /// Optional ids of reference image assets for style transfer. Reference as @Image1, @Image2, etc. in prompt.
        /// </param>
        /// <param name="elements">
        /// Optional elements for character tracking. Reference as @Element1, @Element2, etc. in prompt.
        /// </param>
        /// <param name="keepAudio">
        /// Whether to preserve the original audio from the input video. Automatically disabled when generate_audio is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="postProcessing">
        /// Optional FPS and HDR processing applied before delivery.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoToVideoRequest(
            global::System.Guid videoId,
            string prompt,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::System.Guid? reservedAssetId,
            global::System.Collections.Generic.IList<global::System.Guid>? reservedAssetIds,
            string? type,
            string? modelSlug,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageAssetIds,
            global::System.Collections.Generic.IList<global::Hedra.KlingEditElement>? elements,
            bool? keepAudio,
            global::Hedra.VideoPostProcessingSettings? postProcessing)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.ReservedAssetId = reservedAssetId;
            this.ReservedAssetIds = reservedAssetIds;
            this.Type = type;
            this.ModelSlug = modelSlug;
            this.VideoId = videoId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImageAssetIds = referenceImageAssetIds;
            this.Elements = elements;
            this.KeepAudio = keepAudio;
            this.PostProcessing = postProcessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoToVideoRequest()
        {
        }

    }
}
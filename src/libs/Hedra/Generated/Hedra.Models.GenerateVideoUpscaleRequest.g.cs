
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateVideoUpscaleRequest
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
        /// Default Value: video_upscale
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
        /// The id of the Video asset to upscale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// Computed scale factor derived from target_resolution and source video dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// Target output resolution. Must be one of: 1080p, 2K, 4K.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_resolution")]
        public string? TargetResolution { get; set; }

        /// <summary>
        /// Target output frame rate, from the model's published `target_frame_rates` menu. A source already at or above the target keeps its own rate. Omitted keeps the source rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_fps")]
        public int? TargetFps { get; set; }

        /// <summary>
        /// Interpolation engine from the model's published `fps_engines` menu; requires `target_fps`. Omitted uses the default engine. Non-default engines scale the charge by their published `price_multiplier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps_engine")]
        public string? FpsEngine { get; set; }

        /// <summary>
        /// Per-generation option values, keyed by the option names the model publishes on `/models`. Unknown names and out-of-menu values are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoUpscaleRequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// The id of the Video asset to upscale.
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
        /// Default Value: video_upscale
        /// </param>
        /// <param name="modelSlug">
        /// The slug of the model to use. Alternative to the deprecated model id.
        /// </param>
        /// <param name="upscaleFactor">
        /// Computed scale factor derived from target_resolution and source video dimensions.
        /// </param>
        /// <param name="targetResolution">
        /// Target output resolution. Must be one of: 1080p, 2K, 4K.
        /// </param>
        /// <param name="targetFps">
        /// Target output frame rate, from the model's published `target_frame_rates` menu. A source already at or above the target keeps its own rate. Omitted keeps the source rate.
        /// </param>
        /// <param name="fpsEngine">
        /// Interpolation engine from the model's published `fps_engines` menu; requires `target_fps`. Omitted uses the default engine. Non-default engines scale the charge by their published `price_multiplier`.
        /// </param>
        /// <param name="options">
        /// Per-generation option values, keyed by the option names the model publishes on `/models`. Unknown names and out-of-menu values are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoUpscaleRequest(
            global::System.Guid videoId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::System.Guid? reservedAssetId,
            global::System.Collections.Generic.IList<global::System.Guid>? reservedAssetIds,
            string? type,
            string? modelSlug,
            double? upscaleFactor,
            string? targetResolution,
            int? targetFps,
            string? fpsEngine,
            object? options)
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
            this.UpscaleFactor = upscaleFactor;
            this.TargetResolution = targetResolution;
            this.TargetFps = targetFps;
            this.FpsEngine = fpsEngine;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoUpscaleRequest" /> class.
        /// </summary>
        public GenerateVideoUpscaleRequest()
        {
        }

    }
}
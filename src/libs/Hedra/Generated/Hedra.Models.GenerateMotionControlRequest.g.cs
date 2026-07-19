
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Motion Control request for transferring motion from a reference video to a character image.<br/>
    /// Processed through V2V infrastructure internally.
    /// </summary>
    public sealed partial class GenerateMotionControlRequest
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
        /// Default Value: motion_control
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Deprecated. Use `model_slug` to select the motion control model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// The slug of the Motion Control model. Alternative to `ai_model_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// The id of the video asset to use as motion reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// The id of the character image asset to animate with the motion from the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_keyframe_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid StartKeyframeId { get; set; }

        /// <summary>
        /// Video generation parameters including text_prompt and character_orientation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_video_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.GeneratedVideoInputs GeneratedVideoInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMotionControlRequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// The id of the video asset to use as motion reference.
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the character image asset to animate with the motion from the video.
        /// </param>
        /// <param name="generatedVideoInputs">
        /// Video generation parameters including text_prompt and character_orientation.
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
        /// Default Value: motion_control
        /// </param>
        /// <param name="modelSlug">
        /// The slug of the Motion Control model. Alternative to `ai_model_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateMotionControlRequest(
            global::System.Guid videoId,
            global::System.Guid startKeyframeId,
            global::Hedra.GeneratedVideoInputs generatedVideoInputs,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::System.Guid? reservedAssetId,
            global::System.Collections.Generic.IList<global::System.Guid>? reservedAssetIds,
            string? type,
            string? modelSlug)
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
            this.StartKeyframeId = startKeyframeId;
            this.GeneratedVideoInputs = generatedVideoInputs ?? throw new global::System.ArgumentNullException(nameof(generatedVideoInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMotionControlRequest" /> class.
        /// </summary>
        public GenerateMotionControlRequest()
        {
        }

    }
}
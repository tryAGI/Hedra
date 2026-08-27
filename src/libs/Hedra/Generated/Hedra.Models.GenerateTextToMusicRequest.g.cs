
#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateTextToMusicRequest
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
        /// Default Value: text_to_music
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The slug of the model to use for music generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSlug { get; set; }

        /// <summary>
        /// The prompt describing the music to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional custom lyrics (up to 10,000 characters). Sent to the provider inside the prompt (ElevenLabs prompt-mode reads lyrics from the prompt text and uses them with the requested length to place vocals).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Guarantee an instrumental track (no vocals). Mutually exclusive with `lyrics`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_instrumental")]
        public bool? ForceInstrumental { get; set; }

        /// <summary>
        /// The requested music length in milliseconds (3s-10min). Explicit null lets the model pick the length (auto); an omitted field keeps the 10s default. Auto bills the maximum length up front and refunds the unused share once the actual duration is known, so an auto request requires a balance covering a full-length track even when the delivered one is shorter. Individual models may enforce a lower maximum.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_length_ms")]
        public int? MusicLengthMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToMusicRequest" /> class.
        /// </summary>
        /// <param name="modelSlug">
        /// The slug of the model to use for music generation.
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the music to generate.
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
        /// Default Value: text_to_music
        /// </param>
        /// <param name="lyrics">
        /// Optional custom lyrics (up to 10,000 characters). Sent to the provider inside the prompt (ElevenLabs prompt-mode reads lyrics from the prompt text and uses them with the requested length to place vocals).
        /// </param>
        /// <param name="forceInstrumental">
        /// Guarantee an instrumental track (no vocals). Mutually exclusive with `lyrics`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="musicLengthMs">
        /// The requested music length in milliseconds (3s-10min). Explicit null lets the model pick the length (auto); an omitted field keeps the 10s default. Auto bills the maximum length up front and refunds the unused share once the actual duration is known, so an auto request requires a balance covering a full-length track even when the delivered one is shorter. Individual models may enforce a lower maximum.<br/>
        /// Default Value: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTextToMusicRequest(
            string modelSlug,
            string prompt,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::System.Guid? reservedAssetId,
            global::System.Collections.Generic.IList<global::System.Guid>? reservedAssetIds,
            string? type,
            string? lyrics,
            bool? forceInstrumental,
            int? musicLengthMs)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.ReservedAssetId = reservedAssetId;
            this.ReservedAssetIds = reservedAssetIds;
            this.Type = type;
            this.ModelSlug = modelSlug ?? throw new global::System.ArgumentNullException(nameof(modelSlug));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Lyrics = lyrics;
            this.ForceInstrumental = forceInstrumental;
            this.MusicLengthMs = musicLengthMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToMusicRequest" /> class.
        /// </summary>
        public GenerateTextToMusicRequest()
        {
        }

    }
}
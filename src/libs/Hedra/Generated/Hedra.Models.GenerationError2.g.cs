
#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationError2
    {
        /// <summary>
        /// The class of error encountered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.ErrorCode Type { get; set; }

        /// <summary>
        /// Which of several situations sharing `type` actually occurred, when the provider named one. Clients key user-facing copy off the (`type`, `reason_code`) pair and must treat an unrecognized value as absent, falling back to the copy for `type` alone. Absent means `type` says everything we know — not that the finer situation was ruled out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_code")]
        public global::Hedra.GenerationReasonCode? ReasonCode { get; set; }

        /// <summary>
        /// Interpolation values for `reason_code` copy — machine-generated numbers (dimensions, bounds) the client formats into localised text, so no English needs to cross the wire. Keys are declared per reason code: a code that carries values always uses the same key names for them. **Presence is not guaranteed.** A code may arrive with no values, or with only some of them, when the side that rejected the request did not know the rest — the same situation can be detected at more than one point in the pipeline, and those points do not all hold the same facts. Clients must therefore treat every key as optional and fall back to the copy for `reason_code` alone, or for `type` alone, rather than interpolating a missing value. Absent entirely whenever `reason_code` is, and for codes whose copy needs no values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_params")]
        public object? ReasonParams { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The input field this failure blames, as the rejecting side named it. Set only when the failure is about one specific field — typically an `INVALID_ARGUMENT` schema rejection — so clients can point at it without parsing `message`. Absent means the failure is not attributable to a single field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Every field-level problem this failure reported, as `field`/`message` pairs in the rejecting side's own vocabulary — so a caller with several bad fields can fix them all in one pass instead of one per round-trip. `param` remains the primary field. Absent when the failure named at most one field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violations")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Violations { get; set; }

        /// <summary>
        /// Credits the generation required. Set only for `INSUFFICIENT_BALANCE`, and only when the failing check knew the cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_needed")]
        public int? CreditsNeeded { get; set; }

        /// <summary>
        /// Credits the account had when the generation was rejected. Set only for `INSUFFICIENT_BALANCE`. Paired with `credits_needed` so clients can render the shortfall without parsing `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_available")]
        public int? CreditsAvailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationError2" /> class.
        /// </summary>
        /// <param name="type">
        /// The class of error encountered.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="reasonCode">
        /// Which of several situations sharing `type` actually occurred, when the provider named one. Clients key user-facing copy off the (`type`, `reason_code`) pair and must treat an unrecognized value as absent, falling back to the copy for `type` alone. Absent means `type` says everything we know — not that the finer situation was ruled out.
        /// </param>
        /// <param name="reasonParams">
        /// Interpolation values for `reason_code` copy — machine-generated numbers (dimensions, bounds) the client formats into localised text, so no English needs to cross the wire. Keys are declared per reason code: a code that carries values always uses the same key names for them. **Presence is not guaranteed.** A code may arrive with no values, or with only some of them, when the side that rejected the request did not know the rest — the same situation can be detected at more than one point in the pipeline, and those points do not all hold the same facts. Clients must therefore treat every key as optional and fall back to the copy for `reason_code` alone, or for `type` alone, rather than interpolating a missing value. Absent entirely whenever `reason_code` is, and for codes whose copy needs no values.
        /// </param>
        /// <param name="param">
        /// The input field this failure blames, as the rejecting side named it. Set only when the failure is about one specific field — typically an `INVALID_ARGUMENT` schema rejection — so clients can point at it without parsing `message`. Absent means the failure is not attributable to a single field.
        /// </param>
        /// <param name="violations">
        /// Every field-level problem this failure reported, as `field`/`message` pairs in the rejecting side's own vocabulary — so a caller with several bad fields can fix them all in one pass instead of one per round-trip. `param` remains the primary field. Absent when the failure named at most one field.
        /// </param>
        /// <param name="creditsNeeded">
        /// Credits the generation required. Set only for `INSUFFICIENT_BALANCE`, and only when the failing check knew the cost.
        /// </param>
        /// <param name="creditsAvailable">
        /// Credits the account had when the generation was rejected. Set only for `INSUFFICIENT_BALANCE`. Paired with `credits_needed` so clients can render the shortfall without parsing `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationError2(
            global::Hedra.ErrorCode type,
            string message,
            global::Hedra.GenerationReasonCode? reasonCode,
            object? reasonParams,
            string? param,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? violations,
            int? creditsNeeded,
            int? creditsAvailable)
        {
            this.Type = type;
            this.ReasonCode = reasonCode;
            this.ReasonParams = reasonParams;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.Violations = violations;
            this.CreditsNeeded = creditsNeeded;
            this.CreditsAvailable = creditsAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationError2" /> class.
        /// </summary>
        public GenerationError2()
        {
        }

    }
}
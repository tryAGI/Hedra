
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
        /// Credits the generation required. Set only for `MISSING_CREDITS`, and only when the failing check knew the cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_needed")]
        public int? CreditsNeeded { get; set; }

        /// <summary>
        /// Credits the account had when the generation was rejected. Set only for `MISSING_CREDITS`. Paired with `credits_needed` so clients can render the shortfall without parsing `message`.
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
        /// <param name="param">
        /// The input field this failure blames, as the rejecting side named it. Set only when the failure is about one specific field — typically an `INVALID_ARGUMENT` schema rejection — so clients can point at it without parsing `message`. Absent means the failure is not attributable to a single field.
        /// </param>
        /// <param name="creditsNeeded">
        /// Credits the generation required. Set only for `MISSING_CREDITS`, and only when the failing check knew the cost.
        /// </param>
        /// <param name="creditsAvailable">
        /// Credits the account had when the generation was rejected. Set only for `MISSING_CREDITS`. Paired with `credits_needed` so clients can render the shortfall without parsing `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationError2(
            global::Hedra.ErrorCode type,
            string message,
            global::Hedra.GenerationReasonCode? reasonCode,
            string? param,
            int? creditsNeeded,
            int? creditsAvailable)
        {
            this.Type = type;
            this.ReasonCode = reasonCode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
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
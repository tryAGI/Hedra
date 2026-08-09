
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Fine-grained generation reason codes, published as ``reason_code``.<br/>
    /// The second level under the coarse ``ErrorCode`` (AIP-193), mirroring<br/>
    /// ``AgentErrorCode`` on the agent side. ``ErrorCode`` drives HTTP status and<br/>
    /// is deliberately small; this says which of several situations sharing that<br/>
    /// code actually occurred, and it is what clients key user-facing copy off.<br/>
    /// ``ErrorCode`` also carries the default retryability, but it cannot always<br/>
    /// be right: one coarse code can cover both a deterministic refusal and a<br/>
    /// nondeterministic one. Where a provider draws that distinction and we can<br/>
    /// read it, the reason code is what refines it — see<br/>
    /// ``MODERATION_OUTPUT_TRANSIENT``.<br/>
    /// ``MODERATION_FAILED`` is the motivating case. It currently renders one<br/>
    /// sentence — "Try rephrasing your prompt" — for every moderation rejection,<br/>
    /// which is wrong advice when a provider refused a reference image or video<br/>
    /// for depicting a real person: the prompt is not the problem and rephrasing<br/>
    /// it cannot help. Providers name that case distinctly (BytePlus as the<br/>
    /// ``.PrivacyInformation`` sub-code, Google as a likeness message), so the<br/>
    /// distinction is theirs, not ours to infer.<br/>
    /// Append-only, and pinned by ``test/lint/test_error_codes_are_append_only``:<br/>
    /// clients switch on these string values.
    /// </summary>
    public enum GenerationReasonCode
    {
        /// <summary>
        /// 
        /// </summary>
        ImageAspectRatioUnsupported,
        /// <summary>
        /// 
        /// </summary>
        ImageResolutionUnsupported,
        /// <summary>
        /// 
        /// </summary>
        ModerationLikeness,
        /// <summary>
        /// 
        /// </summary>
        ModerationOutputTransient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationReasonCode value)
        {
            return value switch
            {
                GenerationReasonCode.ImageAspectRatioUnsupported => "IMAGE_ASPECT_RATIO_UNSUPPORTED",
                GenerationReasonCode.ImageResolutionUnsupported => "IMAGE_RESOLUTION_UNSUPPORTED",
                GenerationReasonCode.ModerationLikeness => "MODERATION_LIKENESS",
                GenerationReasonCode.ModerationOutputTransient => "MODERATION_OUTPUT_TRANSIENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_ASPECT_RATIO_UNSUPPORTED" => GenerationReasonCode.ImageAspectRatioUnsupported,
                "IMAGE_RESOLUTION_UNSUPPORTED" => GenerationReasonCode.ImageResolutionUnsupported,
                "MODERATION_LIKENESS" => GenerationReasonCode.ModerationLikeness,
                "MODERATION_OUTPUT_TRANSIENT" => GenerationReasonCode.ModerationOutputTransient,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Fine-grained generation reason codes, published as ``reason_code``.<br/>
    /// The second level under the coarse ``ErrorCode`` (AIP-193), mirroring<br/>
    /// ``AgentErrorCode`` on the agent side. ``ErrorCode`` drives HTTP status and<br/>
    /// retryability and is deliberately small; this says which of several<br/>
    /// situations sharing that code actually occurred, and it is what clients key<br/>
    /// user-facing copy off.<br/>
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
        ModerationLikeness,
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
                GenerationReasonCode.ModerationLikeness => "MODERATION_LIKENESS",
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
                "MODERATION_LIKENESS" => GenerationReasonCode.ModerationLikeness,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Which of several situations sharing `type` actually occurred, when the provider named one. Clients key user-facing copy off the (`type`, `reason_code`) pair and must treat an unrecognized value as absent, falling back to the copy for `type` alone. Absent means `type` says everything we know — not that the finer situation was ruled out.
    /// </summary>
    public sealed partial class GenerationErrorReasonCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
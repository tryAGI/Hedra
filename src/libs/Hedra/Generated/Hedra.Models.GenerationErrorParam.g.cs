
#nullable enable

namespace Hedra
{
    /// <summary>
    /// The input field this failure blames, as the rejecting side named it. Set only when the failure is about one specific field — typically an `INVALID_ARGUMENT` schema rejection — so clients can point at it without parsing `message`. Absent means the failure is not attributable to a single field.
    /// </summary>
    public sealed partial class GenerationErrorParam
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
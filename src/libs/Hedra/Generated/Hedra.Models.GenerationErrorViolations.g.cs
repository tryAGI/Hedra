
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Every field-level problem this failure reported, as `field`/`message` pairs in the rejecting side's own vocabulary — so a caller with several bad fields can fix them all in one pass instead of one per round-trip. `param` remains the primary field. Absent when the failure named at most one field.
    /// </summary>
    public sealed partial class GenerationErrorViolations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Maximum width/height ratio for image inputs (image only). Scale-invariant, so the caller must crop rather than resize to satisfy it; enforced by pre-dispatch input validation.
    /// </summary>
    public sealed partial class InputSlotMaxAspectRatio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
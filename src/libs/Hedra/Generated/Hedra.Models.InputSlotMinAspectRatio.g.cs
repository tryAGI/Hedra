
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Minimum width/height ratio for image inputs (image only). Scale-invariant, so the caller must crop rather than resize to satisfy it; enforced by the BytePlus input normalization at dispatch.
    /// </summary>
    public sealed partial class InputSlotMinAspectRatio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
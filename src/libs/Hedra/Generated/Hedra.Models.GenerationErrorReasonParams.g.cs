
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Interpolation values for `reason_code` copy — machine-generated numbers (dimensions, bounds) the client formats into localised text, so no English needs to cross the wire. Keys are declared per reason code. Absent whenever `reason_code` is, and for codes whose copy needs no values.
    /// </summary>
    public sealed partial class GenerationErrorReasonParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
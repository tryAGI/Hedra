
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Interpolation values for `reason_code` copy — machine-generated numbers (dimensions, bounds) the client formats into localised text, so no English needs to cross the wire. Keys are declared per reason code: a code that carries values always uses the same key names for them. **Presence is not guaranteed.** A code may arrive with no values, or with only some of them, when the side that rejected the request did not know the rest — the same situation can be detected at more than one point in the pipeline, and those points do not all hold the same facts. Clients must therefore treat every key as optional and fall back to the copy for `reason_code` alone, or for `type` alone, rather than interpolating a missing value. Absent entirely whenever `reason_code` is, and for codes whose copy needs no values.
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

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Machine-readable conditional input rules the backend enforces at submit. Each rule's `when` is conjunctive over the closed keys `resolution` (matched against the effective resolution: the requested one, or `default_resolution` when omitted) and `references_present`; its `then` narrows the advertised menus — `audio_input_max_duration_ms` caps the driving audio, `durations` (int ms) replaces the offered duration menu, and `disallowed_resolutions` removes resolutions. When several rules match: numeric caps take the minimum, `durations` intersect, `disallowed_resolutions` union. Null when the model declares none.
    /// </summary>
    public sealed partial class AIModelConditionalConstraints
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
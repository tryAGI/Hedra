
#nullable enable

namespace Hedra
{
    /// <summary>
    /// If set to (min, max), the model accepts any keyframe whose width/height ratio is in [min, max], not just the values in ``aspect_ratios``. The model snaps the output to its internal grid. ``aspect_ratios`` then serves as UI/preset labels rather than as an enum gate.
    /// </summary>
    public sealed partial class AIModelAspectRatioRange
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
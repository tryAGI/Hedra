
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Target output frame rate, from the model's published `target_frame_rates` menu. A source already at or above the target keeps its own rate. Omitted keeps the source rate.
    /// </summary>
    public sealed partial class GenerateVideoUpscaleResponseTargetFps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
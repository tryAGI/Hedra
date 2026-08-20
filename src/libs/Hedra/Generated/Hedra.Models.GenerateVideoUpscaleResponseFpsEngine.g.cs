
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Interpolation engine from the model's published `fps_engines` menu; requires `target_fps`. Omitted uses the default engine. Non-default engines scale the charge by their published `price_multiplier`.
    /// </summary>
    public sealed partial class GenerateVideoUpscaleResponseFpsEngine
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
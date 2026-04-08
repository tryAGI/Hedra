
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Target output resolution (e.g. '1080p', '2K', '4K'). Preferred over upscale_factor.
    /// </summary>
    public sealed partial class GenerateImageUpscaleResponseTargetResolution
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
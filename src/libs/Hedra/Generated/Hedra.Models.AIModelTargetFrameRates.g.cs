
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Output frame rates a video-upscale model can interpolate up to. Absent when the model offers no frame-rate control.
    /// </summary>
    public sealed partial class AIModelTargetFrameRates
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
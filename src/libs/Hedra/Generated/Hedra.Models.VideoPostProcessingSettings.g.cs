
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional enhancement stages applied after a video model completes.<br/>
    /// These are generation-level controls rather than model-catalog variants:<br/>
    /// the selected video model still produces the source, then Temporal applies<br/>
    /// the requested stages to that same asset before delivery completes.
    /// </summary>
    public sealed partial class VideoPostProcessingSettings
    {
        /// <summary>
        /// Optional output frame rate. Omitted preserves the model output rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_fps")]
        public int? TargetFps { get; set; }

        /// <summary>
        /// Interpolation quality used with target_fps. Omitted uses standard; high consumes twice the FPS-stage credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps_engine")]
        public global::Hedra.VideoPostProcessingSettingsFpsEngine2? FpsEngine { get; set; }

        /// <summary>
        /// Convert the completed SDR video to a 10-bit HDR output.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hdr")]
        public bool? Hdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPostProcessingSettings" /> class.
        /// </summary>
        /// <param name="targetFps">
        /// Optional output frame rate. Omitted preserves the model output rate.
        /// </param>
        /// <param name="fpsEngine">
        /// Interpolation quality used with target_fps. Omitted uses standard; high consumes twice the FPS-stage credits.
        /// </param>
        /// <param name="hdr">
        /// Convert the completed SDR video to a 10-bit HDR output.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPostProcessingSettings(
            int? targetFps,
            global::Hedra.VideoPostProcessingSettingsFpsEngine2? fpsEngine,
            bool? hdr)
        {
            this.TargetFps = targetFps;
            this.FpsEngine = fpsEngine;
            this.Hdr = hdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPostProcessingSettings" /> class.
        /// </summary>
        public VideoPostProcessingSettings()
        {
        }

    }
}
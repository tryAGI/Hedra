
#nullable enable

namespace Hedra
{
    /// <summary>
    /// One camera pose at a normalized point in the generated clip.
    /// </summary>
    public sealed partial class CameraKeyframe
    {
        /// <summary>
        /// When this pose applies, from 0 at the start to 1 at the end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Horizontal camera angle around the subject, in degrees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azimuth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Azimuth { get; set; }

        /// <summary>
        /// Vertical camera angle around the subject, in degrees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Elevation { get; set; }

        /// <summary>
        /// Camera distance from the subject, in normalized scene units.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraKeyframe" /> class.
        /// </summary>
        /// <param name="time">
        /// When this pose applies, from 0 at the start to 1 at the end.
        /// </param>
        /// <param name="azimuth">
        /// Horizontal camera angle around the subject, in degrees.
        /// </param>
        /// <param name="elevation">
        /// Vertical camera angle around the subject, in degrees.
        /// </param>
        /// <param name="distance">
        /// Camera distance from the subject, in normalized scene units.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CameraKeyframe(
            double time,
            double azimuth,
            double elevation,
            double distance)
        {
            this.Time = time;
            this.Azimuth = azimuth;
            this.Elevation = elevation;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraKeyframe" /> class.
        /// </summary>
        public CameraKeyframe()
        {
        }

    }
}
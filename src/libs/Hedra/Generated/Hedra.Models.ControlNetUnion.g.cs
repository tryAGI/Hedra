
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ControlNetUnion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditioning_scale")]
        public double? ConditioningScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_mode")]
        public string? ControlMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_step_percent")]
        public double? BeginStepPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_step_percent")]
        public double? EndStepPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_guidance_start")]
        public double? ControlGuidanceStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_guidance_end")]
        public double? ControlGuidanceEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNetUnion" /> class.
        /// </summary>
        /// <param name="conditioningScale"></param>
        /// <param name="controlMode"></param>
        /// <param name="beginStepPercent"></param>
        /// <param name="endStepPercent"></param>
        /// <param name="controlGuidanceStart"></param>
        /// <param name="controlGuidanceEnd"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ControlNetUnion(
            double? conditioningScale,
            string? controlMode,
            double? beginStepPercent,
            double? endStepPercent,
            double? controlGuidanceStart,
            double? controlGuidanceEnd)
        {
            this.ConditioningScale = conditioningScale;
            this.ControlMode = controlMode;
            this.BeginStepPercent = beginStepPercent;
            this.EndStepPercent = endStepPercent;
            this.ControlGuidanceStart = controlGuidanceStart;
            this.ControlGuidanceEnd = controlGuidanceEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNetUnion" /> class.
        /// </summary>
        public ControlNetUnion()
        {
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// A named input mode grouping mutually exclusive input slots.<br/>
    /// Each mode represents a distinct way to use the model (e.g., image_to_video<br/>
    /// vs first_last_frame_to_video). The frontend selects one mode at a time and<br/>
    /// presents only that mode's slots.<br/>
    /// The text_to_video mode (no input files) is always implicitly available<br/>
    /// for VIDEO type models and is never included in the inputs list.<br/>
    /// `aspect_ratios` is the mode's own, which is not the model's<br/>
    /// wherever the media changes it: MiniMax H3 offers six ratios from a prompt,<br/>
    /// none from a start frame, and a seventh (`adaptive`) from reference images.<br/>
    /// A model stamps its `supported_aspect_ratios` onto the modes it declares<br/>
    /// (`VideoModel.declarative_input_modes`, and `ai_models._image_input_modes`<br/>
    /// for image), and `union_variant_inputs` carries each variant's onto the<br/>
    /// family's published entry, so one card states the ratios per mode rather<br/>
    /// than per variant.<br/>
    /// The four resolution fields after it answer the same question about output<br/>
    /// size: Kling 1.6 renders 720p from a prompt and 1080p from a start frame, and<br/>
    /// Flux Kontext sizes an edit from the image it is given. `ai_models.to_api`<br/>
    /// stamps all four from what the variant itself publishes.<br/>
    /// All five are absent where a family's variants declare the same mode with<br/>
    /// different values, which is a family that has not settled the mode. The<br/>
    /// model's own field then stands, and `group_collapse` keeps the variants<br/>
    /// rather than publishing one entry that drops the other answer.
    /// </summary>
    public sealed partial class InputMode
    {
        /// <summary>
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Ordered list of input slots available in this mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Hedra.InputSlot> Slots { get; set; }

        /// <summary>
        /// Output aspect ratios offered in this mode, which may differ from the model's. Absent where the mode states none, and where a family's variants declare the same mode with different ratios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratios")]
        public global::System.Collections.Generic.IList<string>? AspectRatios { get; set; }

        /// <summary>
        /// Output resolutions offered in this mode, which may differ from the model's; an empty list is a mode that offers no choice of resolution. Absent where the mode states none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolutions")]
        public global::System.Collections.Generic.IList<string>? Resolutions { get; set; }

        /// <summary>
        /// Output resolution this mode renders when the request omits one. Absent where the mode offers no resolution, and where it states none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_resolution")]
        public string? DefaultResolution { get; set; }

        /// <summary>
        /// Whether this mode accepts a custom resolution. Absent where the mode states none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_resolution")]
        public bool? CustomResolution { get; set; }

        /// <summary>
        /// Width and height for each aspect_ratio and resolution tuple this mode offers. Absent where the mode states none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Hedra.Dimension>>? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        /// <param name="mode">
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </param>
        /// <param name="slots">
        /// Ordered list of input slots available in this mode.
        /// </param>
        /// <param name="aspectRatios">
        /// Output aspect ratios offered in this mode, which may differ from the model's. Absent where the mode states none, and where a family's variants declare the same mode with different ratios.
        /// </param>
        /// <param name="resolutions">
        /// Output resolutions offered in this mode, which may differ from the model's; an empty list is a mode that offers no choice of resolution. Absent where the mode states none.
        /// </param>
        /// <param name="defaultResolution">
        /// Output resolution this mode renders when the request omits one. Absent where the mode offers no resolution, and where it states none.
        /// </param>
        /// <param name="customResolution">
        /// Whether this mode accepts a custom resolution. Absent where the mode states none.
        /// </param>
        /// <param name="dimensions">
        /// Width and height for each aspect_ratio and resolution tuple this mode offers. Absent where the mode states none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMode(
            string mode,
            global::System.Collections.Generic.IList<global::Hedra.InputSlot> slots,
            global::System.Collections.Generic.IList<string>? aspectRatios,
            global::System.Collections.Generic.IList<string>? resolutions,
            string? defaultResolution,
            bool? customResolution,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Hedra.Dimension>>? dimensions)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
            this.AspectRatios = aspectRatios;
            this.Resolutions = resolutions;
            this.DefaultResolution = defaultResolution;
            this.CustomResolution = customResolution;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        public InputMode()
        {
        }

    }
}